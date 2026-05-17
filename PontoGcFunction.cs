using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;

namespace PontoFunction
{
    public class PontoGcFunction(IUserService userService) : IHttpFunction
    {
        public async Task HandleAsync(HttpContext context)
        {
            if (context.Request.Method != HttpMethods.Post)
            {
                context.Response.StatusCode = StatusCodes.Status405MethodNotAllowed;
                return;
            }

            var punchDto = await System.Text.Json.JsonSerializer.DeserializeAsync<PunchDto>(context.Request.Body);

            await userService.PunchIn(punchDto);

            context.Response.StatusCode = StatusCodes.Status200OK;
        }
    }
}
