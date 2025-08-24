﻿using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title is too short.");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryentry = _db.DiaryEntries.Find(id);
            if (diaryentry == null)
            {
                return NotFound();
            }
            return View(diaryentry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            if (obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title is too short.");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
           if (id==null || id==0)
            {
                return NotFound();
            }
            DiaryEntry? diaryentry = _db.DiaryEntries.Find(id);
            if(diaryentry== null)
            {
                return NotFound();

            }
            return View(diaryentry);
        }
        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            _db.DiaryEntries.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
           

        }

    }
}