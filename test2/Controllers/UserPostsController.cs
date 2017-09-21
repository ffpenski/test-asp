using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcDocument.Models;

namespace test2.Controllers
{
    public class UserPostsController : Controller
    {
        private UserPostDBContext db = new UserPostDBContext();

        // GET: UserPosts
        public ActionResult Index()
        {
            return View(db.UserPosts.ToList());
        }

        // GET: UserPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPost userPost = db.UserPosts.Find(id);
            if (userPost == null)
            {
                return HttpNotFound();
            }
            return View(userPost);
        }

        // GET: UserPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PostName")] UserPost userPost)
        {
            if (ModelState.IsValid)
            {
                db.UserPosts.Add(userPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userPost);
        }

        // GET: UserPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPost userPost = db.UserPosts.Find(id);
            if (userPost == null)
            {
                return HttpNotFound();
            }
            return View(userPost);
        }

        // POST: UserPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PostName")] UserPost userPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userPost);
        }

        // GET: UserPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserPost userPost = db.UserPosts.Find(id);
            if (userPost == null)
            {
                return HttpNotFound();
            }
            return View(userPost);
        }

        // POST: UserPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserPost userPost = db.UserPosts.Find(id);
            db.UserPosts.Remove(userPost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
