﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Testing;

namespace Azure.Extensions.AspNetCore.DataProtection.Blobs.Tests
{
    public class DataProtectionTestEnvironment: TestEnvironment
    {
        public DataProtectionTestEnvironment() : base("extensions")
        {
        }

        public static DataProtectionTestEnvironment Instance { get; } = new DataProtectionTestEnvironment();
        public string StorageAccountName => GetVariable("BLOB_STORAGE_ACCOUNT_NAME");
        public string StorageAccountKey => GetVariable("BLOB_STORAGE_ACCOUNT_KEY");
    }
}