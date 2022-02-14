﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Telemetry.Diagnostics
{
    using System;

    internal interface ICosmosInstrumentation : IDisposable
    {
        public DiagnosticAttributes Attributes { get; }

        public void MarkFailed(Exception ex);

        public void AddAttributesToScope();
    }
}
