using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCSOLIDDemo.Domain.Models;
using MVCSOLIDDemo.Application.Business;

namespace MVCSOLIDDemo.UI.Controllers {
    public class UserController : Controller {
        //private UserBusiness UserManager = new UserBusiness();

        // GET: User
        public ActionResult Index() {
            //return View(UserManager.GetAll());
            return View(new List<MVCSOLIDDemo.UI.Models.User>());
        }

        // GET: User/Details/5
        public ActionResult Details(Guid? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //User user = UserManager.GetById(id);
            //if (user == null) {
            //    return HttpNotFound();
            //}
            //return View(user);

            return View();
        }

        // GET: User/Create
        public ActionResult Create() {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Password,Active,Sex")] User user) {
            if (ModelState.IsValid) {
                user.Id = Guid.NewGuid();

               //UserManager.Save(user);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(Guid? id) {
            
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //User user = UserManager.GetById(id);

            //if (user == null) {
            //    return HttpNotFound();
            //}
            //return View(user);

            return View();
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Password,Active,Sex")] User user) {
            if (ModelState.IsValid) {
                //UserManager.Update(user);

                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(Guid? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //User user = UserManager.GetById(id);

            //if (user == null) {
            //    return HttpNotFound();
            //}
            //return View(user);
            return View();
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id) {
            
            //UserManager.Delete(id);

            return RedirectToAction("Index");
        }

        public PartialViewResult UserListPartial(string Sex, string Email, string Name) {

            Sex = (Sex == "Ambos" ? "" : Sex);

            //return PartialView(UserManager.UserFilter(Sex, Email, Name));
            return PartialView();
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {

            }
            base.Dispose(disposing);
        }
    }
}
