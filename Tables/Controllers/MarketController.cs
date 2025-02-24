﻿using Microsoft.AspNetCore.Mvc;
using Tables.Models;

namespace Tables.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly MyDbContextProduct _context;

        public ProductController(MyDbContextProduct context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
