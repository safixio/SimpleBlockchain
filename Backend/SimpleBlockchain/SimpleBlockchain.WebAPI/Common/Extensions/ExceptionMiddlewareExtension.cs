﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using SimpleBlockchain.WebAPI.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SimpleBlockchain.WebAPI.Common.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseExceptionHandler(appError =>
            {
                appError.Run(async (context) =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(new ErrorDetail()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }
    }
}
