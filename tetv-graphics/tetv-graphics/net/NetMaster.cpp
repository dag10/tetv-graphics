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
#include "net/NetMaster.h"

NetMaster::NetMaster(QObject * parent)
    : NetAbstract(parent)
{
    m_server = new QTcpServer(this);

    connect(m_server, SIGNAL(newConnection()), this, SLOT(handleConnection()));

    m_server->listen(QHostAddress::Any, DEFAULT_PORT);

    qDebug() << "LISTENTING ON PORT" << DEFAULT_PORT;
}

void NetMaster::sendToAll(NetPacket * packet, QTcpSocket * exclude)
{
    foreach(QTcpSocket *socket, m_sockets)
        if (socket != exclude)
            packet->writeOut(socket);
}

void NetMaster::handleConnection()
{
    QTcpSocket * socket = m_server->nextPendingConnection();
    connect(socket, SIGNAL(disconnected()), this, SLOT(handleDisconnection()));
    m_sockets.append(socket);

    qDebug() << "CONNECTION";
}

void NetMaster::handleDisconnection()
{
    QTcpSocket * socket = (QTcpSocket*)sender();
    m_sockets.removeAll(socket);

    qDebug() << "DISCONNECTION";
}