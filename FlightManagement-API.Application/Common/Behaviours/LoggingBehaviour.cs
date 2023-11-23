using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace FlightManagement_API.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest>(ILogger<TRequest> logger) : IRequestPreProcessor<TRequest>
    {
        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName= typeof(TRequest).Name;
            logger.LogInformation("FlightManagement Request: {Name} {@Request}",
                requestName, request);
        }
    }
}
