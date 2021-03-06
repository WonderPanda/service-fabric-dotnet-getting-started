﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace StatelessBackendService.Interfaces
{
    using System.Threading.Tasks;
    using Microsoft.ServiceFabric.Services.Remoting;
    using System.Collections.Generic;

    public interface IStatelessBackendService : IService
    {
        Task<long> GetCountAsync(string requestId, IEnumerable<KeyValuePair<string, string>> correlationContextHeader);
    }
}