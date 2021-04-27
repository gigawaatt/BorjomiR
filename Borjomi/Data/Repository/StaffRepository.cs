using Borjomi.Data.Intetfaces;
using Borjomi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data.Repository
{
    public class StaffRepository : IStaff
    {
        private AppDBContent appDBContent;




        public StaffRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Staff> AllStaff => appDBContent.Staff;

        public IEnumerable<Staff> getActiveStaff => appDBContent.Staff.Where(c => c.is_active == true);

        public Staff ObjStaff(int staffId) => appDBContent.Staff.FirstOrDefault(c => c.id == staffId);
        
    }
}
