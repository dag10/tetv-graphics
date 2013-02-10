/* Copyright (c) 2013, Drew Gottlieb
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice, this list
 * 	  of conditions and the following disclaimer.
 * - Redistributions in binary form must reproduce the above copyright notice, this
 * 	  list of conditions and the following disclaimer in the documentation and/or
 * 	  other materials provided with the distribution.
 * - Neither the name of the TETV Graphics nor the names of its contributors may be
 * 	  used to endorse or promote products derived from this software without specific
 * 	  prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
 * BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF
 * THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

#include <QtNetwork/QTcpServer>
#include <QtNetwork/QTcpSocket>
#include <QtCore/QDebug>
#include "consts.h"
#include "net/AbstractNetHandler.h"
#include "net/NetMaster.h"

NetMaster::NetMaster(QObject * parent)
    : NetAbstract(parent)
{
    m_server = new QTcpServer(this);

    connect(m_server, SIGNAL(newConnection()), this, SLOT(handleConnection()));
}

const QString & NetMaster::begin()
{
    bool listening = m_server->listen(QHostAddress::Any, DEFAULT_PORT);

    if (listening)
    {
        qDebug() << "Listening on port" << DEFAULT_PORT;
        return QString();
    }
    else
    {
        qCritical() << "Failed to listen on port" << m_server->serverPort() << ":" << m_server->errorString();
        return m_server->errorString();
    }
}

void NetMaster::broadcastPacket(NetPacket * packet)
{
    for (int i = 0; i < m_sockets.count(); i++)
        packet->writeOut(m_sockets.at(i));
}

void NetMaster::handleConnection()
{
    QTcpSocket * socket = m_server->nextPendingConnection();
    connect(socket, SIGNAL(disconnected()), this, SLOT(handleDisconnection()));
    connect(socket, SIGNAL(readyRead()), this, SLOT(dataReady()));
    m_sockets.append(socket);
    m_connectedClients.appendRow(new QStandardItem(socket->peerAddress().toString()));

    qDebug() << "New connection from" << socket->peerAddress().toString();

    // Send initial packets:
    
    NetPacket("INIT_DONE").writeOut(socket);
}

void NetMaster::handleDisconnection()
{
    QTcpSocket * socket = (QTcpSocket*)sender();
    m_sockets.removeAll(socket);
    m_connectedClients.removeRow(m_connectedClients.match(
        m_connectedClients.index(0, 0),
        Qt::DisplayRole,
        socket->peerAddress().toString()).at(0).row());

    qDebug() << "Slave disconnected from" << socket->peerAddress().toString();
}

void NetMaster::dataReady()
{
    QTcpSocket * socket = (QTcpSocket*)sender();

    while (socket->bytesAvailable())
        sendToHandlers(&NetPacket(socket));
}

void NetMaster::sendToHandlers(NetPacket * packet)
{
    qDebug().nospace() << "[" << packet->receivedFrom()->peerAddress().toString() << "]"
        << " Processing packet: " << packet->name();

    if (!handlerExists(packet->name()))
        return;

    QList<AbstractNetHandler*> * handlers = m_netHandlers.value(packet->name());

    bool forward = false;

    for (int i = 0; i < handlers->count(); i++)
        if (handlers->at(i)->handle(*packet))
            forward = true;

    if (forward)
        broadcastPacket(packet);
}

QStandardItemModel & NetMaster::connectedClients()
{
    return m_connectedClients;
}