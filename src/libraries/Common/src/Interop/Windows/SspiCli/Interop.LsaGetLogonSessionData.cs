// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class SspiCli
    {
#if DLLIMPORTGENERATOR_ENABLED
        [GeneratedDllImport(Interop.Libraries.SspiCli, SetLastError = true)]
        internal static partial int LsaGetLogonSessionData(
#else
        [DllImport(Interop.Libraries.SspiCli, SetLastError = true)]
        internal static extern int LsaGetLogonSessionData(
#endif
            ref LUID LogonId,
            out SafeLsaReturnBufferHandle ppLogonSessionData);
    }
}
