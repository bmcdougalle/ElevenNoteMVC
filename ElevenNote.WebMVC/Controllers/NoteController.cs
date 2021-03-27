using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElevenNote.Models;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View(model);
        }

        //Add method here VVVV
        //GET


        public ActionResult Create()
        {
            return View();
        }
    }
}