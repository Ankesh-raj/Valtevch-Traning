﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntityy;

namespace HospitalManagementDAL
{
    public class AdminDAL
    {
        public List<Admin> Admins = new List<Admin>();

        Admin admin1 = new Admin("Ankesh", 1, "chandan", "12345@");
        Admin admin2 = new Admin("kiran@gmail", 2, "kiran", "56789@");

        public List<Admin> GetAllAdminsDAL()
        {
            Admins.Add(admin1);
            Admins.Add(admin2);



            return Admins;

        }

    }
}
