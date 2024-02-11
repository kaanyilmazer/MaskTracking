using Business.Abstract;
using Business.Concrete;
using Business.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;


public class PttManager : ISupplierService
{
    private readonly IApplicantService _applicantService;

    public PttManager(IApplicantService personManager)
    {
        _applicantService = personManager;
    }

    public async Task GiveMask(Person person)
    {
        if (await _applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.Ad +   " Adlı Kişiye Maske Verildi.");
        }
        else
        {
            Console.WriteLine(person.Ad +  " Adlı Kişi İçin Maske Verilemedi");
        }
    }

}
