namespace CustomMiddleWare
{
    public static class CustomMiddleware
    {
        public static IApplicationBuilder UseLogUrl(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoggerRequestDelegate>();
        }
    }
}
