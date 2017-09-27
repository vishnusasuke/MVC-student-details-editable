using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication7.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Student()
        {
            Student s = new Student();
            s.firstname = "Vishnu";
            s.lastname = "Vardhan";
            return View(s);
        }
	}
}