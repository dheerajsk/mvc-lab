using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBasics
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                StringBuilder sb = new StringBuilder("");
                foreach (var value in context.ModelState.Values)
                {
                    if (value.Errors.Count > 0)
                    {
                        for (int i = 0; i < value.Errors.Count; i++)
                        {
                            sb.Append(value.Errors[i].ErrorMessage);
                            sb.AppendLine("\n");
                        }
                    }
                }
                context.HttpContext.Response.StatusCode = 400;
                context.Result = new ContentResult
                {
                    Content = sb.ToString()
                };
            }

        }
    }
}
