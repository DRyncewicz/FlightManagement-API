﻿using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Exceptions;
using FluentValidation;

namespace FlightManagement_API.Application.Common.Behaviours
{
    public class ExceptionHandlerBehaviour<TRequest, TResponse>(ILogger<ExceptionHandlerBehaviour<TRequest, TResponse>> logger) : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch (NotFoundException ex)
            {
                var requestName = typeof(TRequest).Name;
                logger.LogInformation(ex,
                    "FlightManagement API Not Found Exception: record was not found for Request {Name} {@Request}", requestName,
                    request);
                throw;
            }
            catch (ValidationException ex)
            {
                var requestName = typeof(TRequest).Name;
                logger.LogInformation(ex,
                    "FlightManagement API Validation Exception: bad value/s for Request {Name} {@Request}", requestName,
                    request);
                throw;
            }
            catch (Exception ex)
            {
                var requestName = typeof(TRequest).Name;
                logger.LogError(ex,
                    "FlightManagement API Exception: Unhandled Exception for Request {Name} {@Request}", requestName,
                    request);
                throw;
            }
        }
    }
}