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

#include <QtGui/QApplication>
#include <QtGui/QPushButton>
#include <QtGui/QLabel>
#include <QtGui/QBoxLayout>
#include <QtGui/QPlastiqueStyle>
#include <QtCore/QFile>
#include <QtCore/QDebug>

#include "consts.h"
#include "ui/windows/modewindow.h"
#include "ui/windows/programwindow.h"

int main(int argc, char *argv[])
{
    QApplication app(argc, argv);

    // Set up application
    app.setStyle(new QPlastiqueStyle());
    app.setApplicationName("TETV Graphics");
    app.setApplicationVersion(QString("Version %1.%2.%3")
        .arg(TETVGFX_VERSION_MAJOR)
        .arg(TETVGFX_VERSION_MINOR)
        .arg(TETVGFX_VERSION_PATCH));
    app.setOrganizationName("tetv");

    // Load stylesheet

    QFile style(":/res/css/application.css");
    style.open(QFile::ReadOnly);
    app.setStyleSheet(style.readAll());

    // Mode window

    ModeWindow modePrompt;
    int mode = modePrompt.exec();

    if (mode == QDialog::Rejected)
        return 0;

    // Program window

    ProgramWindow pgmWindow(mode == ModeWindow::MasterMode, modePrompt.netManager());
    pgmWindow.show();

    return app.exec();
}