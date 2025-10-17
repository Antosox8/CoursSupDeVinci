// See https://aka.ms/new-console-template for more information
Person person1 = new Person();
Person person2 = new Person();

Console.WriteLine("Quelle est le nom de P1 ?");
person1.Lastname = Console.ReadLine();
Console.WriteLine("Quelle est le nom de P2 ?");
person2.Lastname = Console.ReadLine();

Console.WriteLine("Quelle est le prénom de P1 ?");
person1.Firstname = Console.ReadLine();
Console.WriteLine("Quelle est le prénom de P2 ?");
person2.Firstname = Console.ReadLine();

Console.WriteLine("Quelle est votre Date de Naissance de P1 (au format JJ/MM/YYYY) ?");
String birthDate1 = Console.ReadLine();
Console.WriteLine("Quelle est votre Date de Naissance P2 (au format JJ/MM/YYYY) ?");
String birthDate2 = Console.ReadLine();

Console.WriteLine("Quelle est l'adresse de P1 (au format rue,codePostal,Ville) ?");
String address1 = Console.ReadLine();
Console.WriteLine("Quelle est l'adresse de P2 (au format rue,codePostal,Ville) ?");
String address2 = Console.ReadLine();

person1.AdressDetails = address1.Split(",").ToList();
person2.AdressDetails = address2.Split(",").ToList();

if (DateTime.TryParse(birthDate1, out DateTime birthdate1))
{
    person1.Birthdate =  birthdate1;
}
else
{
    Console.WriteLine($"La date de P1 est mal renseignée");
}
if (DateTime.TryParse(birthDate2, out DateTime birthdate2))
{
    person2.Birthdate =  birthdate2;
}
else
{
    Console.WriteLine($"La date de P2 est mal renseignée");
}

// Console.WriteLine($"Bonjour {person1.Firstname} {person1.Lastname},");
// Console.WriteLine($"tu as {person1.getYearsOld().ToString()} ans et tu habites au {person1.getStreet()} {person1.getPostcode()} {person1.getCity()}.");

if (person1.getYearsOld() > person2.getYearsOld())
{
    Console.WriteLine($"{person1.Firstname} {person1.Lastname} est plus agé(e) que {person2.Firstname} {person2.Lastname} de {(person1.getYearsOld() - person2.getYearsOld()).ToString()} an(s)");
}
else if (person1.getYearsOld() < person2.getYearsOld())
{
    Console.WriteLine($"{person2.Firstname} {person2.Lastname} est plus agé(e) que {person1.Firstname} {person1.Lastname} de {(person2.getYearsOld() - person1.getYearsOld()).ToString()} an(s)");
}
else
{
    Console.WriteLine($"{person1.Firstname} {person1.Lastname} a le même age que {person2.Firstname} {person2.Lastname}");
}
