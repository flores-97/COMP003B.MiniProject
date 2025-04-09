namespace COMP003B.MiniProject.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");

            if (context != null)
            {
                await _next(context);

                Console.WriteLine($"[Response] {context.Response.StatusCode}");
            }
        }
    }
}
