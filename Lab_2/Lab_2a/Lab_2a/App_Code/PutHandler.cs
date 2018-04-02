using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class PutHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        response.Write("PUT-Http-SDA:ParmA = " + request["ParmA"] + ",ParmB = " + request["ParmB"]);
    }

    public bool IsReusable
    {
        get { return false; }
    }
}