using Borjomi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data.Intetfaces
{
   public interface IStaff
    {
        IEnumerable<Staff> AllStaff { get;}

        IEnumerable<Staff> getActiveStaff { get;}

        Staff ObjStaff(int staffId);
    }
}
