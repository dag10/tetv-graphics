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

#ifndef NETPACKET_H
#define NETPACKET_H

#include <QtCore/QString>
#include <QtCore/QList>
#include <QtCore/QVariant>
#include <QtCore/QIODevice>
#include <QtCore/QDataStream>
#include <QtCore/QDebug>

class NetPacket : public QObject {
    Q_OBJECT
    Q_PROPERTY(QString name READ name WRITE setName)

public:
    NetPacket(const QString & name, const QVariant firstPayload = QVariant()) {
        m_name = name;

        if (firstPayload.isValid())
            m_args.append(firstPayload);
    }

    NetPacket(QIODevice * io)
    {
        QDataStream in(io);
        in.setVersion(QDataStream::Qt_4_8);
        quint8 numArgs;
        in >> m_name;
        in >> m_args;
        for (int i = 0; i < numArgs; i++)
            addArg(QVariant(in));
    }

    void writeOut(QIODevice * io)
    {
        QByteArray packetData;
        QDataStream dataBuilder(&packetData, QIODevice::ReadWrite);
        dataBuilder << m_name << (quint8)args();

        for (int i = 0; i < args(); i++)
            dataBuilder << m_args.at(i);

        QDataStream out(io);
        out.setVersion(QDataStream::Qt_4_8);
        out << (quint16)packetData.size();
        out.writeBytes(packetData.constData(), packetData.size());

        qDebug() << "Wrote packet with size:" << packetData.size();
    }

    int args() const { return m_args.count(); }
    QString name() const { return m_name; }
    const QVariant & arg(int i) const { return m_args.at(i); }

    void setName(const QString & name) { m_name = name; }
    void addArg(const QVariant & arg) { m_args.append(arg); }

private:
    QString m_name;
    QList<QVariant> m_args;
};

#endif // NETPACKET_H