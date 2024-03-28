// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System.Numerics;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;
bool isAuthenticated = false;

//variables --> camelCase
//classes --> PascalCase

if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi1";

for (int i = 0; i < loans.Length;i++)
{
    Console.WriteLine(loans[i]);

}

CourseManager courseManager = new (new CourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Description);
}

Console.WriteLine("Kod Bitti"); 

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678987";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345676543";
customer2.FirstName = "Kerem";
customer2.LastName = "Alışık";
customer2.CustomerNumber = "456279";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.TaxNumber = "11234567890";
customer3.CustomerNumber = "98765";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "HujiYazılım";
customer4.TaxNumber = "65789876543";
customer4.CustomerNumber = "6789876";

//deger tiplerde atama yapıldıktan sonra bağlantı biter.
//value types --> int,bool,double...     stack'te saklanıyor
//reference types --> array, class, interface...     heap'te değer atanıyor. Bu yüzden atamalardan sonra yapılan değişiklikleri görmeye devam ediyor.

BaseCustomer[] customers = { customer1, customer2, customer3, customer4,};  //inherit ve implement edilen sınıflar inherit veya implement edildiği sınıfın referanslarını tutabilir!!!!!

//POLYMORPHİSM
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}



