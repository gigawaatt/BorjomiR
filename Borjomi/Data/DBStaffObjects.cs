using Borjomi.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data
{
    public class DBStaffObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Staff.Any())
            {
                //content.Staff.AddRange(Staffs.Select(staff));

                content.Staff.Add(
                    new Staff
                    {
                        first_name = "Александр",
                        middle_name = "Владимирович",
                        last_name = "Иванов",
                        bdate = DateTime.ParseExact("2019-04-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        is_active = true,
                        create_date = DateTime.ParseExact("2019-05-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    });



                content.SaveChanges();
            }
        }




        private static List<Staff> staff;
        public static List<Staff> Staffs
        {
            get
            {
                if (staff == null)
                {
                    var list = new Staff[]
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

                    foreach (Staff item in list)
                        staff.Add(item);
                }

                return staff;

            }


        }

    }
}

