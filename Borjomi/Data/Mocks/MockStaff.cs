using Borjomi.Data.Intetfaces;
using Borjomi.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data.Mocks
{
    public class MockStaff : IStaff
    {


        public IEnumerable<Staff> AllStaff
        {
            get
            {
                return new List<Staff>
                {
                    new Staff{first_name = "Александр" ,
                        middle_name = "Владимирович",
                        last_name = "Иванов",
                        bdate = DateTime.ParseExact("2019-04-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        is_active = true,
                        create_date = DateTime.ParseExact("2019-05-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    },
                    new Staff{first_name = "Елена",
                        last_name = "Булдакова",
                        birth_date = DateTime.ParseExact("1990-06-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        bdate = DateTime.ParseExact("2018-04-26", "yyyy-MM-dd", CultureInfo.InvariantCulture), 
                        edate = DateTime.ParseExact("2019-05-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        is_active = false,
                        create_date = DateTime.ParseExact("2019-05-19", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    },
                    new Staff{first_name = "Владимир", 
                        last_name = "Лисничук", 
                        bdate = DateTime.ParseExact("2019-04-24", "yyyy-MM-dd", CultureInfo.InvariantCulture), 
                        is_active = false,
                        create_date = DateTime.ParseExact("2019-05-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    }

                };

            }

        }

        public IEnumerable<Staff> getActiveStaff { get; set;}

        public Staff ObjStaff(int staffId)
        {
            throw new NotImplementedException();
        }
    }
}
