// See https://aka.ms/new-console-template for more information
Person person = new Person();

Console.WriteLine("Quelle est votre Nom ?");
person.Lastname = Console.ReadLine();
Console.WriteLine("Quelle est votre Prénom ?");
person.Firstname = Console.ReadLine();
Console.WriteLine("Quelle est votre Date de Naissance (au format JJ/MM/YYYY) ?");
String birthDate = Console.ReadLine();
Console.WriteLine("Quelle est votre adresse (au format rue,codePostal,Ville) ?");
String address = Console.ReadLine();

List<String> addressDetails = address.Split(",").ToList();
person.AdressDetails = addressDetails;

if (DateTime.TryParse(birthDate, out DateTime birthdate))
{
    person.Birthdate =  birthdate;
}
else
{
    Console.WriteLine($"La date est mal renseignée");
}

Console.WriteLine($"Bonjour {person.Firstname} {person.Lastname},");
Console.WriteLine($"tu as {person.getYearsOld().ToString()} ans et tu habites au {person.getStreet()} {person.getPostcode()} {person.getCity()}.");

