using Borjomi.Data;
using Borjomi.Data.Intetfaces;
using Borjomi.Data.Models;
using Borjomi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Mvc;
using System.Data.Entity;

namespace Borjomi.Controllers
{
    public class HomeController : Controller
    {
        private IStaff _allStaff;

        

        //public StaffController(IStaff allStaff)
        //{
           // _allStaff = allStaff;
        //}


        private AppDBContent db;
        public HomeController(AppDBContent context, IStaff allStaff)
        {
            db = context;
            _allStaff = allStaff;
        }


        /* public async Task<ViewResult> Index()
         {
             //ViewBag.Title = "Сотрудники";
             //StaffListViewModel obj = new StaffListViewModel();
             //obj.AllStaff = db.Staff.ToListAsync();
             return View(await db.Staff.ToListAsync());
         }*/

        /*public ViewResult Index()
        {
           
            StaffListViewModel obj = new StaffListViewModel();
            obj.AllStaff = db.Staff.AsEnumerable();
            return View(obj);
        }
        */

        



        public ActionResult Index(int? page,string active, string name)
        {
            IQueryable<Staff> staff = (IQueryable<Staff>)_allStaff.AllStaff;
            int pageSize = 20;  // количество элементов на странице
            int pageNumber = (page ?? 1);

            

            List<string> _active = new List<string>() { "Все", "Трудоустроенные", "Уволенные" };
            

            if (active == "Трудоустроенные")
                {
                    staff = (IQueryable<Staff>)_allStaff.getActiveStaff;
                }
            else if (active == "Уволенные")
                {
                    staff = staff.Where(x => x.is_active == false);
                }
 
            if (!String.IsNullOrEmpty(name))
            {
                staff = staff.Where(p => (p.last_name + " " + p.first_name + " " + p.middle_name).Contains(name));
            }

            var count = staff.Count();
            var items = staff.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            PageViewModel pageViewModel = new PageViewModel(count, pageNumber, pageSize);


            StaffListViewModel obj = new StaffListViewModel
            {
                AllStaff = staff.ToList(),
                Active_users = new SelectList(_active),
                Check_name = name,
                PageViewModel = pageViewModel
            };


            
            return View(obj);

        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Staff Employee)
        {
            db.Staff.Add(Employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }





        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Staff employee = _allStaff.AllStaff.FirstOrDefault(p => p.id == id);
                if (employee != null)
                    return View(employee);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Staff employee)
        {
            db.Staff.Update(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Staff employee = _allStaff.AllStaff.FirstOrDefault(p => p.id == id);
                if (employee != null)
                    return View(employee);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Staff employee = _allStaff.AllStaff.FirstOrDefault(p => p.id == id);
                if (employee != null)
                {
                    db.Staff.Remove(employee);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Staff employee = _allStaff.AllStaff.FirstOrDefault(p => p.id == id);
                if (employee != null)
                    return View(employee);
            }
            return NotFound();
        }



    }
}
