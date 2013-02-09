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

#include <QtNetwork/QTcpSocket>
#include <QtNetwork/QHostAddress>
#include <QtCore/QDebug>
#include "consts.h"
#include "net/NetSlave.h"

NetSlave::NetSlave(QObject * parent)
    : NetAbstract(parent)
{
    m_socket = new QTcpSocket(this);
    receivingInitialPackets = true;
    nextPacketSize = 0;
    
    connect(m_socket, SIGNAL(connected()), this, SLOT(handleConnection()));
    connect(m_socket, SIGNAL(connected()), this, SIGNAL(connected()));
    connect(m_socket, SIGNAL(disconnected()), this, SLOT(handleDisconnection()));
    connect(m_socket, SIGNAL(disconnected()), this, SIGNAL(disconnected()));
    connect(
        m_socket,
        SIGNAL(error(QAbstractSocket::SocketError)),
        this,
        SLOT(handleError(QAbstractSocket::SocketError)));
    connect(
        m_socket,
        SIGNAL(error(QAbstractSocket::SocketError)),
        this,
        SIGNAL(error(QAbstractSocket::SocketError)));
    connect(m_socket, SIGNAL(readyRead()), this, SLOT(dataReady()));
}

void NetSlave::begin()
{
    m_socket->connectToHost(QHostAddress::LocalHost, DEFAULT_PORT);

    qDebug() << "CONNECTING ON PORT" << DEFAULT_PORT;
}

void NetSlave::send(NetPacket * packet)
{
    packet->writeOut(m_socket);
}

void NetSlave::handleConnection()
{
    qDebug() << "CONNECTED";
}

void NetSlave::handleDisconnection()
{
    qDebug() << "DISCONNECTED";
}

void NetSlave::handleError(QAbstractSocket::SocketError error)
{
    qDebug() << "ERROR:" << error;
}

void NetSlave::processInitialPackets()
{
    receivingInitialPackets = false;

    while (!initialPackets.isEmpty())
    {
        processPacket(initialPackets.first());
        initialPackets.pop_front();
    }
}

void NetSlave::processPacket(NetPacket * packet)
{
    qDebug() << "Received:" << packet->name();

    if (receivingInitialPackets)
    {
        if (packet->name() == "INIT_DONE")
            emit receivedInitialPackets();
        else
            initialPackets.push_back(packet);
    }
    else
    {
        // TODO: Process packet properly, here.

        qDebug() << "Processing:" << packet->name();
    }
}

void NetSlave::dataReady()
{
    qDebug() << "Data is ready.";

    if (nextPacketSize == 0) // We're going to receive the packet size
    {
        qDebug() << "Bytes available:" << m_socket->bytesAvailable();

        if (m_socket->bytesAvailable() < sizeof(nextPacketSize))
            return;

        QDataStream in((QIODevice*)m_socket);
        in.setVersion(QDataStream::Qt_4_8);
        in >> nextPacketSize;

        qDebug() << "Next packet size:" << nextPacketSize;
    }
    
    if (nextPacketSize > 0) // We know what this packet size will be
    {
        if (m_socket->bytesAvailable() >= nextPacketSize)
        {
            processPacket(new NetPacket((QIODevice*)this));
            nextPacketSize = 0;
        }
    }
}

bool NetSlave::handle(const NetPacket & packet)
{
    QString name = packet.name();

    if (name == "PRINT")
    {
        qDebug() << "SERVER SAYS:" << packet.arg(0).toString();
    }

    return false;
}