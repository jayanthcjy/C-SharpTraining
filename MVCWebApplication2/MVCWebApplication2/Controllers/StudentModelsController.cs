using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWebApplication2.Data;
using MVCWebApplication2.Models;

namespace MVCWebApplication2.Controllers
{
    public class StudentModelsController : Controller
    {
        private readonly MVCWebApplication2Context _context;

        public StudentModelsController(MVCWebApplication2Context context)
        {
            _context = context;
        }

        // GET: StudentModels
        public async Task<IActionResult> Index()
        {
              return _context.StudentModel != null ? 
                          View(await _context.StudentModel.ToListAsync()) :
                          Problem("Entity set 'MVCWebApplication2Context.StudentModel'  is null.");
        }

        // GET: StudentModels/Details/5
        public IActionResult Details()
        {
           

            return View();
        }

        // GET: StudentModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserName,Password")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: StudentModels/Edit/5
        public IActionResult Edit()
        {

            return View();
        }
        

        // POST: StudentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        // GET: StudentModels/Delete/5
        public IActionResult Delete()
        {
           
            return View();
        }

        
       
    }
}
