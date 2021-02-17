// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Functions.Worker.Pipeline
{
    /// <summary>
    /// A delegate that can process an event.
    /// </summary>
    /// <param name="context">The context for the event invocation.</param>
    /// <returns>A <see cref="Task"/> that represents the invocation process.</returns>
    public delegate Task FunctionExecutionDelegate(FunctionContext context);
}
