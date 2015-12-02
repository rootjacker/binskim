﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;

[assembly: AssemblyVersion(Microsoft.CodeAnalysis.BinSkim.VersionConstants.AssemblyVersion)]
[assembly: AssemblyFileVersion(Microsoft.CodeAnalysis.BinSkim.VersionConstants.FileVersion)]

namespace Microsoft.CodeAnalysis.BinSkim
{
    public static class VersionConstants
    {
        public const string Version = "1.2.1-beta";
        public const string AssemblyVersion = "1.2.1";
        public const string FileVersion = "1.2.1.0";
    }
}
