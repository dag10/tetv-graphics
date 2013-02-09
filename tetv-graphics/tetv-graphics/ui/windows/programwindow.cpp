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

#include <QtGui/QGridLayout>
#include <QtGui/QLabel>
#include <QtGui/QPushButton>
#include <QtGui/QDockWidget>
#include <QtGui/QMainWindow>
#include <QtCore/QDebug>

#include "net/NetMaster.h"
#include "net/NetSlave.h"
#include "ui/panels/TestPanel.h"
#include "ui/controls/TPushButton.h"
#include "ui/windows/programwindow.h"

// Preferred inner resolution: 1280 x 744

ProgramWindow::ProgramWindow(bool isMaster, NetSlave * slave, QWidget * parent)
    : QMainWindow(parent)
{
    m_isMaster = isMaster;
    setWindowTitle(QString("TETV Graphics - %1").arg(isMaster ? "Master" : "Slave"));
    setMinimumSize(1024, 700);
    resize(1280, 744);

    // Init Net

    if (m_isMaster)
    {
        netManager = new NetMaster(this);
    }
    else
    {
        netManager = slave;
    }

    // Create columns

    QWidget * columnsContainer = new QWidget(this);
    this->setCentralWidget(columnsContainer);
    QHBoxLayout * columns = new QHBoxLayout(columnsContainer);

    QVBoxLayout * leftColumnLayout = new QVBoxLayout();
    leftColumnLayout->addLayout(leftColumn = new QVBoxLayout(), 0);
    leftColumnLayout->addStretch(1);
    columns->addLayout(leftColumnLayout, 0);

    QVBoxLayout * middleColumnLayout = new QVBoxLayout();
    middleColumnLayout->addLayout(middleColumn = new QVBoxLayout(), 0);
    middleColumnLayout->addStretch(1);
    columns->addLayout(middleColumnLayout, 1);

    QVBoxLayout * rightColumnLayout = new QVBoxLayout();
    rightColumnLayout->addLayout(rightColumn = new QVBoxLayout(), 0);
    rightColumnLayout->addStretch(1);
    columns->addLayout(rightColumnLayout, 0);

    // TODO: Set up panels

    // If slave, process queued received packets

    if (!m_isMaster)
    {
        ((NetSlave*)netManager)->processInitialPackets();
    }
}

void ProgramWindow::initNet()
{
    if (m_isMaster)
    {
        netManager = new NetMaster(this);
    }
    else
    {
        // TODO 
    }
}