﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Interactive.Azure;

public class Routes
{
    public const string PostCreateSession = "/session";
    public const string GetSessionInfo = "/session/{sessionId}";
    public const string PostSessionState = "/session/{sessionId}";
}
