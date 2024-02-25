namespace CustomMiddleWare
{
    public class LoggerRequestDelegate
    {
        private readonly ILogger<LoggerRequestDelegate> _logger;
        /// <summary>
        /// Request Delegate handles pipeline of request. internally it uses Run, Use, Map Delegates.
        /// </summary>
        private readonly RequestDelegate _next;
        public LoggerRequestDelegate(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory?.CreateLogger<LoggerRequestDelegate>() ??
        throw new ArgumentNullException(nameof(loggerFactory));
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"Request URL: {Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(context.Request)}");
            await this._next(context);
        }

    }
}
