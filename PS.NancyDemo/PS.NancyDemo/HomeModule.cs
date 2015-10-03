using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Responses;

namespace PS.NancyDemo
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Func<Request, bool> _isNotAPIClient = request =>
                !request.Headers.UserAgent.ToLower().StartsWith("curl");

            Get["/", ctx => _isNotAPIClient.Invoke(ctx.Request)] = p => View["index.html"];

            Get["/"] = p => "Welcome to the Pluralsight API";

            Get["/courses"] = p => new JsonResponse(Course.List, new DefaultJsonSerializer());

            Get["/courses/{id}"] = p => Response.AsJson(Course.List.SingleOrDefault(x=>x.Id==p.id));

            Post["/courses"] = p =>
                {
                    var name = this.Request.Form.Name;
                    var author = this.Request.Form.Author;
                    var id = Course.AddCourse(name, author);

                    string url = string.Format("{0}/{1}", this.Context.Request.Url, id);

                    return new Response() { StatusCode = HttpStatusCode.Accepted }.WithHeader("Location", url);
                };

        }
    }
}