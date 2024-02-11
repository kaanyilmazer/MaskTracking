using Business.Interfaces;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetAll()
        {
             
            return new List<Person>();   
        }


        public Task<bool> CheckPerson(Person kullanici)
        {
            bool dogrulamaSonucu = false;
            try
            {
                var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(kullanici.TcKimlikNo), kullanici.Ad, kullanici.Soyad, kullanici.DogumTarihi.Year).GetAwaiter().GetResult();
                dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                dogrulamaSonucu = false;
            }
            return Task.FromResult(dogrulamaSonucu);
        }
    }


}


