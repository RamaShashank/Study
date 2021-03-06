﻿using System.Web.Mvc;
using Domas.Web.Mvc.UI;
using Domas.Web.Mvc.Extensions;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult Custom_Command()
        {
            return View();
        }

        public ActionResult CustomCommand_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetEmployees().ToDataSourceResult(request));
        }    
    }
}