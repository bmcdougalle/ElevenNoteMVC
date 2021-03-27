using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElevenNote.Models;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ElevenNote.Services;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            var model = service.GetNotes();
            return View(model);
        }

        //Add method here VVVV
        //GET


        public ActionResult Create()
        {
            return View();
        }

        //add code here
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);

            service.CreateNote(model);

            return RedirectToAction("Index");
        }
    }
}