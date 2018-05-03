using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using marinaTest.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace marinaTest.Controllers
{
  public class ContactController : Controller
  {
    private ContactRepository _ContactRep;
    public ContactController(ContactRepository repo)
    {
      _ContactRep = repo;
    }

    // GET: Contact
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult ContactsAll()
    {
      return Json(_ContactRep.GetContacts());
    }

    public ActionResult ContactsById(int id)
    {
      return Json(_ContactRep.GetContactById(id));
    }


    // GET: Contact/DetailsByName/marina
    public ActionResult ContactsByName(string name)
    {
      return Json(_ContactRep.GetContactByName(name));
    }

    // GET: Contact/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Contact/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: Contact/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: Contact/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: Contact/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: Contact/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}
