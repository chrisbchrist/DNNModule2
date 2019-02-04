using System;
using System.Linq;
using System.Web.Mvc;
using Chris.Modules.DNNModule2.Components;
using Chris.Modules.DNNModule2.Models;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;

namespace Chris.Modules.DNNModule2.Controllers
{
    [DnnHandleError]
    public class ResumeController : DnnController
    {
        // GET: Resume
        public ActionResult Index(int ResumeId = -1)
        {
            if (ResumeId == -1)
            {
                var newResume = new Resume();
                return View(newResume);
            } else
            {
                return View();
            }
     
        }

        [HttpPost]
        public ActionResult Create(Resume r)
        {
            return View();
        }
       
    }
}
