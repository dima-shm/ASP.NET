using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

class PostSumHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;

        if (Single.TryParse(request["X"], out float x) &&
            Single.TryParse(request["Y"], out float y))
        {
            response.Write(x + y);
        }
        else
        {
            response.Write("Значения не были предоставлены, или они не были числами");
        }
    }

    public bool IsReusable
    {
        get { return false; }
    }
}