using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TranslatorService;

namespace Translator.Controllers
{
    public class TranslatorController : Controller
    {
        Translation service = new Translation();
        TranslatorObject obj = new TranslatorObject();

        // GET: Translator
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public JsonResult AjaxCall(string order)
        {
            obj = service.TranslateWord(order);
            return Json(obj.toText);
        }

        [HttpPost]
        public ActionResult Index(string value)
        {
            obj =  service.TranslateWord(value); // Calling TranslatorService class library project to translate the sentence   
            return View("Index2", obj);
        }
    }
}