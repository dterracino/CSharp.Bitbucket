﻿#region License

/*
 * Copyright 2002-2012 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using Spring.Rest.Client;
using Spring.Social;

namespace CSharp.Bitbucket.Api.Interfaces
{
    /// <summary>
    /// Interface specifying a basic set of operations for interacting with Bitbucket.
    /// </summary>
	/// <author>Scott Smith</author>
    public interface IBitbucket : IApiBinding
    {
        /// <summary>
        /// Gets the underlying <see cref="IRestOperations"/> object allowing for consumption of Bitbucket endpoints 
        /// that may not be otherwise covered by the API binding. 
        /// </summary>
        /// <remarks>
        /// The <see cref="IRestOperations"/> object returned is configured to include an OAuth "Authorization" header on all requests.
        /// </remarks>
        IRestOperations RestOperations { get; }
    }
}
