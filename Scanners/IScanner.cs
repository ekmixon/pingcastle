﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using System.Net;

namespace PingCastle.Scanners
{
    public interface IScanner
    {
        void Initialize(string server, int port, NetworkCredential credential);
        void Export(string filename);
        string Name { get; }
        string Description { get; }

        // return false if the user query has been cancelled
        Program.DisplayState QueryForAdditionalParameterInInteractiveMode();
    }
}
