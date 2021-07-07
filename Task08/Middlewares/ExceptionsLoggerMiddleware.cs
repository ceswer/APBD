using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Task08.Middlewares
{
    public class ExceptionsLoggerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string path = "logs.txt";

        public ExceptionsLoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            } catch (Exception exc)
            {
                await LogExceptionAsync(context, exc);
            }
        }

        public async Task LogExceptionAsync(HttpContext context, Exception exc)
        {
            using var stream = new StreamWriter(path, true);
            await stream.WriteLineAsync($"{DateTime.Now},{context.TraceIdentifier},{exc.HResult}");
            await next(context);
        }
    }
}
