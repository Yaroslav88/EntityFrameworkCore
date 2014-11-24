﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Storage;

namespace Microsoft.Data.Entity.Sqlite
{
    public class SqliteDataStoreSource : DataStoreSource<SqliteDataStoreServices, SqliteOptionsExtension>
    {
        public SqliteDataStoreSource([NotNull] DbContextServices services, [NotNull] LazyRef<IDbContextOptions> options)
            : base(services, options)
        {
        }

        public override string Name
        {
            get { return typeof(SqliteDataStore).Name; }
        }
    }
}
