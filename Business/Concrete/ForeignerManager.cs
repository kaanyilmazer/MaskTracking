﻿using Business.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetAll()
    {
        throw new NotImplementedException();
    }
}
