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

#include "ui/controls/TPushButton.h"
#include "ui/windows/programwindow.h"

ProgramWindow::ProgramWindow(bool isMaster, QWidget * parent)
    : QWidget(parent)
{
    m_isMaster = isMaster;
    setWindowTitle(QString("TETV Graphics - %1").arg(isMaster ? "Master" : "Slave"));
    setMinimumSize(1024, 768);

    // Temporary demonstration buttons:

    QGridLayout * layout = new QGridLayout(this);
    layout->setColumnStretch(0, 1);
    layout->setColumnStretch(1, 0);
    layout->setColumnStretch(2, 1);
    layout->setRowStretch(0, 1);
    layout->setRowStretch(4, 1);

    TPushButton * close = new TPushButton("Close");
    layout->addWidget(close, 1, 1);

    TPushButton * btn = new TPushButton("Another test");
    layout->addWidget(btn, 2, 1);

    TPushButton * btn2 = new TPushButton("Hello world!");
    layout->addWidget(btn2, 3, 1);

    connect(close, SIGNAL(clicked()), this, SLOT(close()));

    // TODO: Create three-column UI to start
}