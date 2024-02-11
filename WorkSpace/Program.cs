using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
person.Ad = "Kaan".ToUpper();
person.Soyad = "Yılmazer".ToUpper();
person.TcKimlikNo = "11111111111";
person.DogumTarihi = new DateTime(2002, 05, 24);

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);


