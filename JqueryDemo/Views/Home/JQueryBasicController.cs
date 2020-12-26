using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryDemo.Views.Home
{
    public class JQueryBasicController : Controller
    {
        /// <summary>
        /// Difference between Windows.load and document.ready
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowImageHeightWidth()
        {
            return View();
        }
        public ActionResult IdSelector()
        {
            return View();
        }
        public ActionResult ElementSelector()
        {
            return View();
        }
        public ActionResult ClassSelector()
        {
            return View();
        }

        public ActionResult AttributeSelector()
        {
            return View();
        }
    }
}