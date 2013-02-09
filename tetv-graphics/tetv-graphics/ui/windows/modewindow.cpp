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

#include <QtGui/QVBoxLayout>
#include <QtGui/QLabel>
#include <QtGui/QMessageBox>

#include "ui/controls/TPushButton.h"
#include "ui/windows/modewindow.h"
#include "consts.h"

ModeWindow::ModeWindow(QWidget * parent)
    : QDialog(parent, Qt::WindowSystemMenuHint | Qt::WindowTitleHint)
{
    setFixedSize(250, 300);
    setWindowTitle("TETV Graphics");

    QVBoxLayout * layout = new QVBoxLayout(this);

    // Program title

    QLabel * lblTitle = new QLabel("TETV Graphics");
    lblTitle->setStyleSheet("font: 24px bold;");
    layout->addWidget(lblTitle, 30, Qt::AlignHCenter | Qt::AlignBottom);

    // Version text

    QLabel * lblVersion = new QLabel(QString("Version %1.%2.%3")
        .arg(TETVGFX_VERSION_MAJOR)
        .arg(TETVGFX_VERSION_MINOR)
        .arg(TETVGFX_VERSION_PATCH));
    lblVersion->setStyleSheet("font-weight: bold;");
    layout->addWidget(lblVersion, 30, Qt::AlignHCenter | Qt::AlignTop);

    // Master button

    btnMaster = new TPushButton("Master");
    btnMaster->setFixedSize(170, 50);
    btnMaster->setStyleSheet("font: 18px bold;");
    layout->addWidget(btnMaster, 0, Qt::AlignHCenter);
    connect(btnMaster, SIGNAL(clicked()), this, SLOT(masterClicked()));

    // Slave button

    btnSlave = new TPushButton("Slave");
    btnSlave->setFixedSize(170, 50);
    btnSlave->setStyleSheet("font: 18px bold;");
    layout->addWidget(btnSlave, 0, Qt::AlignHCenter);
    connect(btnSlave, SIGNAL(clicked()), this, SLOT(slaveClicked()));
}

void ModeWindow::masterClicked()
{
    done(MasterMode);
}

void ModeWindow::slaveClicked()
{
    netSlave = new NetSlave(this);

    connect(netSlave, SIGNAL(receivedInitialPackets()), this, SLOT(netSlaveReady()));
    connect(netSlave, SIGNAL(error(QAbstractSocket::SocketError)), this, SLOT(netSlaveError(QAbstractSocket::SocketError)));

    netSlave->begin();
    btnSlave->setEnabled(false);
}

void ModeWindow::netSlaveReady()
{
    emit launchSlave(netSlave);
    done(SlaveMode);
}

void ModeWindow::netSlaveError(QAbstractSocket::SocketError error)
{
    QMessageBox msg;
    QString errorName;
    QDebug(&errorName) << error;
    msg.critical(this, "Error", QString("Failed to connect:\n%1").arg(errorName));
    msg.setFixedSize(450, 200);
    btnSlave->setEnabled(true);
}