using DuzceUni.Data;
using DuzceUni.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Controllers
{
    public class AdminPanelController : Controller
    {
        Context c = new Context();

        //[Authorize]
        public IActionResult Announcement()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Announcement");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var del = c.Blogs.Find(id);
            c.Blogs.Remove(del);
            c.SaveChanges();
            return RedirectToAction("Announcement");
        }
        
        public IActionResult UpdateAnnouncement(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = c.Blogs.Select(m => new Blog
            {
                Id = m.Id,
                Title = m.Title,
                Short_Description = m.Short_Description,
                Description = m.Description,
                Date = m.Date,
                ImageUrl = m.ImageUrl
            }).FirstOrDefault(m => m.Id == id);
            ViewBag.Blogs = c.Blogs.ToList();

            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Blog model, int[] blogIds)
        {
            var entity = c.Blogs.Find(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Title = model.Title;
            entity.Short_Description = model.Short_Description;
            entity.Description = model.Description;
            entity.Date = model.Date;
            entity.ImageUrl = model.ImageUrl;

            c.SaveChanges();

            return RedirectToAction("Announcement");
        }
        public IActionResult Duzce_Welcome()
        {
            var values = c.DuzceWelcomes.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDuzce_Welcome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDuzce_Welcome(DuzceWelcome b)
        {
            c.DuzceWelcomes.Add(b);
            c.SaveChanges();
            return RedirectToAction("Duzce_Welcome");
        }
        public IActionResult DeleteDuzce_Welcome(int id)
        {
            var del = c.DuzceWelcomes.Find(id);
            c.DuzceWelcomes.Remove(del);
            c.SaveChanges();
            return RedirectToAction("Duzce_Welcome");
        }
        public IActionResult UpdateDuzce_Welcome(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = c.DuzceWelcomes.Select(m => new DuzceWelcome
            {
                Id = m.Id,
                Date = m.Date,
                Title = m.Title,
                Description = m.Description,
                Name = m.Name,
                Task = m.Task,
                ImageUrl = m.ImageUrl
            }).FirstOrDefault(m => m.Id == id);
            ViewBag.DuzceWelcomes = c.DuzceWelcomes.ToList();

            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }
        [HttpPost]
        public IActionResult UpdateDuzce_Welcome(DuzceWelcome model, int[] DuzceWelcomeIds)
        {
            var entity = c.DuzceWelcomes.Find(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Date = model.Date;
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Name = model.Name;
            entity.Task = model.Task;
            entity.ImageUrl = model.ImageUrl;

            c.SaveChanges();

            return RedirectToAction("Duzce_Welcome");
        }

        public IActionResult Success()
        {
            var values = c.Successes.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSuccess()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSuccess(Success b)
        {
            c.Successes.Add(b);
            c.SaveChanges();
            return RedirectToAction("Success");
        }
        public IActionResult DeleteSuccess(int id)
        {
            var del = c.Successes.Find(id);
            c.Successes.Remove(del);
            c.SaveChanges();
            return RedirectToAction("Success");
        }
        public IActionResult UpdateSuccess(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = c.Successes.Select(m => new Success
            {
                Id = m.Id,
                Name = m.Name,
                Number = m.Number,
                Icon = m.Icon
            }).FirstOrDefault(m => m.Id == id);
            ViewBag.Successes = c.Successes.ToList();

            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }
        [HttpPost]
        public IActionResult UpdateSuccess(Success model, int[] SuccessIds)
        {
            var entity = c.Successes.Find(model.Id);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Number = model.Number;
            entity.Icon = model.Icon;

            c.SaveChanges();

            return RedirectToAction("Success");
        }
    }
}
