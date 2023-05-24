using System;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}

public class Produkt
{
    private decimal cena;

    public decimal Cena
    {
        get { return cena; }
        set
        {
            cena = value;
            ObliczMoms();
        }
    }

    public decimal Kg { get; set; }
    public string Rozmiar { get; set; }

    private void ObliczMoms()
    {
        decimal moms = cena * 0.50m;
        cena += moms;
    }
}

public class Program
{
    public static void Main()
    {
        Person[] persons = new Person[5];

        persons[0] = new Person
        {
            Name = "Abraham",
            LastName = "Lincoln",
            Address = "Adres Abrahama",
            PhoneNumber = "123456789"
        };

        persons[1] = new Person
        {
            Name = "Gilbert",
            LastName = "Skysovs",
            Address = "Adres Gilberta",
            PhoneNumber = "987654321"
        };

        persons[2] = new Person
        {
            Name = "Flomme",
            LastName = "Flommesen",
            Address = "Adres Flomme",
            PhoneNumber = "456789123"
        };

        persons[3] = new Person
        {
            Name = "Blomme",
            LastName = "Blommesen",
            Address = "Adres Blomme",
            PhoneNumber = "789123456"
        };

        persons[4] = new Person
        {
            Name = "Alexandre",
            LastName = "Alexandresen",
            Address = "Adres Alexandre",
            PhoneNumber = "321654987"
        };

        Produkt produkt = new Produkt();
        produkt.Cena = 200;
        produkt.Kg = 4;
        produkt.Rozmiar = "Medium";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════╗");
        Console.WriteLine("║         Menu                ║");
        Console.WriteLine("╠═════════════════════════════╣");
        Console.WriteLine("║ 1. Skab en person           ║");
        Console.WriteLine("║ 2. Se alle personer         ║");
        Console.WriteLine("║ 3. Opret et produkt         ║");
        Console.WriteLine("║ 4. Se produkt               ║");
        Console.WriteLine("║ 5. Affslute                 ║");
        Console.WriteLine("╚═════════════════════════════╝");

        Console.Write("Vælg en mulighed: ");
        Console.ForegroundColor = ConsoleColor.Green;
        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "1":
                UtworzOsobe(persons);
                break;
            case "2":
                WyswietlOsoby(persons);
                break;
            case "3":
                UtworzProdukt(produkt);
                break;
            case "4":
                WyswietlProdukt(produkt);
                break;
            case "5":
                Console.WriteLine("Lukker programmet...");
                break;
            default:
                Console.WriteLine("Ugyldigt valg.");
                break;
        }

        Console.WriteLine("╔════════════════════════════╗");
        Console.WriteLine("║ Tak fordi du bruger        ║");
        Console.WriteLine("║     fra vores program!     ║");
        Console.WriteLine("╚════════════════════════════╝");

        Console.WriteLine("Tryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }

    private static void UtworzOsobe(Person[] persons)
    {
        Console.Write("Navn: ");
        string navn = Console.ReadLine();

        Console.Write("Efternavn: ");
        string efternavn = Console.ReadLine();

        Console.Write("Adresse: ");
        string adresse = Console.ReadLine();

        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        Person person = new Person
        {
            Name = navn,
            LastName = efternavn,
            Address = adresse,
            PhoneNumber = telefonnummer
        };

        for (int i = 0; i < persons.Length; i++)
        {
            if (persons[i] == null)
            {
                persons[i] = person;
                break;
            }
        }

        Console.WriteLine("Person oprettet!");
    }

    private static void WyswietlOsoby(Person[] persons)
    {
        Console.WriteLine("Alle personer:");
        foreach (var person in persons)
        {
            if (person != null)
            {
                Console.WriteLine($"Navn: {person.Name}");
                Console.WriteLine($"Efternavn: {person.LastName}");
                Console.WriteLine($"Adresse: {person.Address}");
                Console.WriteLine($"Telefonnummer: {person.PhoneNumber}");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
    }

    private static void UtworzProdukt(Produkt produkt)
    {
        Console.Write("Cena: ");
        decimal cena = decimal.Parse(Console.ReadLine());

        Console.Write("Kg: ");
        decimal kg = decimal.Parse(Console.ReadLine());

        Console.Write("Rozmiar: ");
        string rozmiar = Console.ReadLine();

        produkt.Cena = cena;
        produkt.Kg = kg;
        produkt.Rozmiar = rozmiar;

        Console.WriteLine("Produkt oprettet!");
    }

    private static void WyswietlProdukt(Produkt produkt)
    {
        Console.WriteLine("Produkt:");
        Console.WriteLine($"Cena: {produkt.Cena}");
        Console.WriteLine($"Kg: {produkt.Kg}");
        Console.WriteLine($"Rozmiar: {produkt.Rozmiar}");

        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
        Console.ReadKey();
    }
}
