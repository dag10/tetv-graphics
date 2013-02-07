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

#ifndef NETABSTRACT_H
#define NETABSTRACT_H

#include <QtCore/QObject>

class NetAbstract : public QObject {
    Q_OBJECT
    Q_ENUMS(HandlerResponse)

public:
    enum HandlerResponse {
        Continue,   // This handler didn't handle this packet, keep trying other handlers.
        Handled,    // This handler handled it. Don't try other handlers.
        Forward     // This handler handled it; please forward this message to other slaves if master.
    };

    NetAbstract();
    void RegisterHandler(const QString * packetName, NetHandler * handler);
};

#endif // NETABSTRACT_H

// TODO: Create NetHandler class (it's abstract)
/* Here's how it'll work:
    - When a packet is received, each registered NetHandler will be told to Handle() the packet,
        and the Handle() will return a HandlerResponse indicating what we should do. If forward,
        and we are master, we will forward this to all other slaves.
    - That's all I've got so far. I really should try to do this sort of planning while I'm NOT exhausted.