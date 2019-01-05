namespace IPSI.Web.Filters
{
    using System;
    using System.Net;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Newtonsoft.Json;

    public class GlobalExceptionHandler : IExceptionFilter
    {
        private readonly IHostingEnvironment environment;

        public GlobalExceptionHandler(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public void OnException(ExceptionContext context)
        {
            var response = context.HttpContext.Response;
            try
            {
                var result = JsonConvert.SerializeObject(
                    new
                    {
                        //message = customErrorMessage,
                        isError = true,
                        errorCode = (int)response.StatusCode,
                        errorMessage = context.Exception.InnerException?.Message ?? context.Exception.Message,
                        stackTrace = (!this.environment.IsProduction()) ? context.Exception.StackTrace : null,
                        model = string.Empty,
                    });

                response.ContentLength = result.Length;
                response.WriteAsync(result);
            }
            catch (Exception ex)
            {
                var result = JsonConvert.SerializeObject(
                    new
                    {
                        isError = true,
                        errorCode = (int)HttpStatusCode.InternalServerError,
                        errorMessage = ex.InnerException?.Message ?? ex.Message,
                        stackTrace = (!this.environment.IsProduction()) ? ex.StackTrace : null,
                    });

                response.ContentLength = result.Length;
                response.WriteAsync(result);
            }
        }
    }
}
