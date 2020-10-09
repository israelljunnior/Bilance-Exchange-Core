using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Web.Http.Filters;

namespace Bilance_Exchange.Domain.Validators
{
    public class ValidateModelAttribute : Microsoft.AspNetCore.Mvc.Filters.ActionFilterAttribute
    {
        public  void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
