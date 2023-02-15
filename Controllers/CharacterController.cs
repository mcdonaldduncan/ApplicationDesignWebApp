using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ApplicationDesignWebApp;
using ApplicationDesignWebApp.Services;

namespace ApplicationDesignWebApp.Controllers
{
    public class CharacterController : Controller
    {
        CharacterServices services = new CharacterServices();

        // GET: Character
        public ActionResult Index()
        {
            return View(services.GetCharacters());
        }

        // GET: Character/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (services.GetCharacterByID(id, out Character character))
            {
                return View(character);
            }
            else
            {
                return HttpNotFound();
            }

        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Element_Type,Job_Class,ATK,DEF,Mana,HP_Initial,HP_Max,NPC")] Character character)
        {
            if (ModelState.IsValid)
            {
                services.AddCharacter(character);
                return RedirectToAction("Index");
            }

            return View(character);
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (services.GetCharacterByID(id, out Character character))
            {
                return View(character);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Element_Type,Job_Class,ATK,DEF,Mana,HP_Initial,HP_Max,NPC")] Character character)
        {
            if (ModelState.IsValid)
            {
                services.SaveCharacterChanges(character);

                return RedirectToAction("Index");
            }
            return View(character);
        }

        // GET: Character/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (services.GetCharacterByID(id, out Character character))
            {
                return View(character);
            }
            else
            {
                return HttpNotFound();
            }
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            services.DeleteCharacterByID(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            services.Dispose(disposing);
            base.Dispose(disposing);
        }
    }
}
