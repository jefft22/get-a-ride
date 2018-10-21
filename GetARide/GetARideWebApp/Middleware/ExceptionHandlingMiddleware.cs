namespace GetARideWebApp.Middleware
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Features;

    public sealed class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.StatusCode = 418;
                httpContext.Response.Headers.Add("Exception-Type", "TODO-ImplementExceptionHandlingMiddleware");
                await httpContext.Response.WriteAsync("TODO-ImplementExceptionHandlingMiddleware");
            }
        }
    }
}