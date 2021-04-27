using Borjomi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList;

namespace Borjomi.ViewModels
{
    public class StaffListViewModel
    {
        public IEnumerable<Staff> AllStaff { get; set; }
        public SelectList Active_users { get; set; }
        public string Check_name { get; set; }
        public PageViewModel PageViewModel { get; set; }


    }
}
