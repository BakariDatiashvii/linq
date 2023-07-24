//List<int> ricxvebi = new List<int>() { 2, 4, 5, 8, 3, 12, 14,7 };
//var shezgudva = from ob in ricxvebi
//                where ob > 4
//                select ob;
//foreach (var iatem in shezgudva)
//{
//    Console.WriteLine(iatem);
//}
////gagagaga
//var bakari = ricxvebi.Where(x => x % 2 == 0).ToList(); // აქ გამოგვაქ ლუწი რიცხვები
//foreach (var kk in bakari)
//{
//    Console.WriteLine(kk);
//}

//var max = ricxvebi.Select(x => x = ricxvebi.Min()); // აქ ვირჩევთ მინიმუმს 
//int x = max.Max();
//Console.WriteLine(x);


////using linq;
////using System.Linq;
/////------------
//List<Person> xalxi = new List<Person>()
//{
//    new Person(){ Id=1, Name ="bakari", Age = 23,Email = "b@1"},
//    new Person(){ Id=2, Name ="bakari1", Age = 24,Email = "b@2"},
//    new Person(){ Id=3, Name ="bakari2", Age = 15,Email = "b@3"},
//    new Person(){ Id=4, Name ="bakari3", Age = 26,Email = "b@4"},
//    new Person(){ Id=5, Name ="bakari4", Age = 27,Email = "b@5"},
//};

//  xalxi.Select(x => x.Age).ToList();
//foreach (var x in xalxi)
//{
//    Console.WriteLine(x.Name);
//}
//var levaniko = xalxi.Select(personx => new Student()
//{
//    Ids = personx.Id,
//    Names = personx.Name,
//    Ages = personx.Age,
//    Emails = personx.Email,
//}
//).ToList();

//foreach (var item in levaniko)
//{
//    Console.WriteLine($"ID = {item.Ids}, Email = {item.Emails}, Name = {item.Names}, Age = {item.Ages}");
//}


//var maxage = xalxi.Where(x => x.Age > 23).Select(y => new Student() // 20 მეტი სტუდენტები
//                                        {
//                                            Ids = y.Id,
//                                            Names = y.Name,
//                                            Ages = y.Age,
//                                            Emails = y.Email,
//                                        }).ToList();

//foreach (var item in maxage)
//{
//    Console.WriteLine($"ID = {item.Ids}, Email = {item.Emails}, Name = {item.Names}, Age = {item.Ages}");
//}
/////------------ახალი ლისტი select many linq
//using linq;
//using System.Linq;
//var xalxi = new List<Person>()
//{
//    new Person(){ Id=1, Name ="bakari", Age = 23,Email = "b@1",Programing = new List<Tech>()
//    {
//        new Tech() { Tecnology = "c#"},
//        new Tech() { Tecnology = "asp.net"},
//        new  Tech() { Tecnology = "seniori"}
//    }},
//    new Person(){ Id=2, Name ="bakari1", Age = 24,Email = "b@2",Programing = new List<Tech>()
//    {
//        new Tech() { Tecnology = "java"},
//        new Tech() { Tecnology = "cotlini"},
//        new Tech() { Tecnology = "middle"}
//    }},
//    new Person(){ Id=3, Name ="bakari2", Age = 15,Email = "b@3", Programing = new List<Tech>()
//    {
//        new Tech() { Tecnology = "php"},
//        new Tech() { Tecnology = "laravel"},
//        new Tech() { Tecnology = "asistenti"}
//    }},
//    new Person(){ Id=4, Name ="bakari3", Age = 26,Email = "b@4", Programing = new List < Tech >()
//    {
//        new Tech() { Tecnology = "javascript"},
//        new Tech() { Tecnology = "angular"},
//        new Tech() { Tecnology = "seniori"}
//    }},
//    new Person(){ Id=5, Name ="bakari4", Age = 27,Email = "b@5" , Programing = new List < Tech >()
//    {
//        new Tech() { Tecnology = "sql"},
//        new Tech() { Tecnology = "msi sql"},

//    }},
//    new Person(){ Id=6, Name ="bakari", Age = 30,Email = "b@6",Programing = new List<Tech>() }
//};

////var datvla = xalxi.Where(x => x.Programing.Count > 2).ToList(); // მონაცემები მოაქვს რომელის tech არის 2 ზე მეტი, თვლის სხვა ლისტის მონაცემებს
//var datvla1 = xalxi.Where(x => x.Programing.Count > 2 && x.Name == "bakari3").ToList(); // აქ მოაქვს მხოლოდ ამ სახელით && და ||
//Console.ReadLine();
//foreach (var item in datvla)
//{
//    Console.WriteLine(item.Programing);
//}

//var developer = xalxi.SelectMany(x => x.Programing).ToList();

//foreach (var dev in developer)
//{

//    Console.WriteLine(dev.Tecnology);
//}

// ---------------------where linq გაფილტვრა ლიგრძე

//var sia = new List<string>() { "asd", "asdd", "qwertyuio", "wetyuikjhgfd" };
//var sia2 = sia.Where(x => x.Length > 5 || x == "asd").ToList();

//foreach (var item in sia2)  // foreach წვდება პირდაპირ მნიშვნელობებს
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i < sia2.Count; i++)  // for წვდება ინდექსებს რაც არის ლისტში
//{
//    Console.WriteLine(i);
//}
////----------OfType linq
//var monacemebi = new List<object>() {"asd","asdfgh","assfdgh",1,2,3,4,5,6,6.5,'d' } ; //ყველა ტიპს ხედავს object
//var strmonacemebi =  monacemebi.OfType<double>().ToList(); // მოაქვს კონკრეტული ტიპი OfType linq

//foreach (var item in strmonacemebi)
//{
//    Console.WriteLine( item);
//}
////-------------order by linq და destening

//var dalageba = new List<int>() { 1,2,3,4,6,8,-2,0,22};

////var inaxavs = dalageba.OrderBy(x => x).ToList(); // ზრდადობით ალაგებს OrderBy linq

//var klebadoba = dalageba.OrderByDescending(x => x).ToList();   // კლებადობით ალაგებეს  OrderByDescending linq
//foreach (var i in klebadoba) 
//{
//    Console.WriteLine(i);
//}
//var sushi = new List<string>() { "tebzi1", "tebzi22", "tebzi333", "tebzi4444", "tebzi5555", };
//var wama = sushi.Where(x => x.Length  > 7).OrderBy(x => x).ToList();// გავფილტრეთ where ით linq ი დავალაგეთ ზრდადობით OrderBy
//foreach (var x in wama)
//{
//    Console.WriteLine(x);
//}

//using linq;
//using System.Linq;
/////------------
//List<Person> xalxi = new List<Person>()
//{
//    new Person(){ Id=7, Name ="bakari", Age = 50,Email = "b@1"},
//    new Person(){ Id=2, Name ="bakari1", Age = 24,Email = "b@2"},
//    new Person(){ Id=3, Name ="bakari2", Age = 15,Email = "b@3"},
//    new Person(){ Id=4, Name ="aakari31", Age = 28,Email = "b@4"},
//    new Person(){ Id=5, Name ="bakari4", Age = 27,Email = "b@5"},
//};
//var saxeli = xalxi.Where(x => x.Id > 3).OrderBy(x => x.Age).ToList();// where OrderBy ჯერ ფილტრავს Id და მერე ზრდადობია მიხედვით ალაგებს
//foreach (var x in saxeli)
//{
//    Console.WriteLine(x.Age);
//}


////------------- ThenBy ----operator  order by linq და destening
///
using linq;
using System.Linq;
///------------
List<Person> xalxi = new List<Person>()
{
    new Person(){ Id=1, Name ="aakari", Age = 50,Email = "b@1"},
    new Person(){ Id=1, Name ="bakari1", Age = 50,Email = "b@2"},
    new Person(){ Id=3, Name ="cakari2", Age = 15,Email = "b@3"},
    new Person(){ Id=4, Name ="dakari31", Age = 28,Email = "b@4"},
    new Person(){ Id=4, Name ="kakari4", Age = 28,Email = "b@5"},
};
var dalageba = xalxi.OrderBy(x => x.Age).ThenBy(x => x.Id).ThenBy(x => x.Name).ToList();// სამი მონაცემის დალაგება თუ მონაცემები ერთმანეთს ემთხვევა ThenBy linq 
foreach (var item in dalageba)
{
    Console.WriteLine($"{item.Age}, {item.Id},{item.Name}, {item.Email}");
}

