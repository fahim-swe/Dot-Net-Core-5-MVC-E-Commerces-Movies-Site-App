﻿using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Models;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public class CinemasServices : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasServices(AppDbContext context): base(context)
        {

        }
    }
}
