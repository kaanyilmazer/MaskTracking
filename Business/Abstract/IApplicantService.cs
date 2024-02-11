﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
         List<Person> GetAll();
        Task<bool> CheckPerson(Person person);
       
    }
}
