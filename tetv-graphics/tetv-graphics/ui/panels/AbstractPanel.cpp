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
#include <QtCore/QDebug>
#include "ui/panels/AbstractPanel.h"

AbstractPanel::AbstractPanel(QWidget * parent)
    : QFrame(parent)
{
    setMinimumWidth(200);

    QVBoxLayout * mainLayout = new QVBoxLayout(this);
    mainLayout->setMargin(0);
    
    // Title label

    lblTitle = new QLabel();
    lblTitle->setFixedHeight(19);
    lblTitle->setFont(QFont("Arial", 8, QFont::Light));
    lblTitle->setObjectName("title");
    mainLayout->addWidget(lblTitle, 0);

    // Body widget

    m_grid = new QVBoxLayout();
    m_grid->setMargin(6);
    mainLayout->addLayout(m_grid, 1);
}

void AbstractPanel::setTitle(const QString & title)
{
    lblTitle->setText(title);
}

QString AbstractPanel::title() const
{
    return lblTitle->text();
}

QVBoxLayout * AbstractPanel::grid()
{
    return m_grid;
}

void AbstractPanel::addDivider()
{
    QFrame * hr = new QFrame();
    hr->setContentsMargins(0, 2, 0, 2);
    hr->setFrameShape(QFrame::HLine);
    hr->setFrameShadow(QFrame::Sunken);
    hr->setFixedHeight(1);
    hr->setObjectName("hr");
    grid()->addWidget(hr);
}