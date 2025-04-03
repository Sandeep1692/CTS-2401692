//Crocodile croc = new Crocodile();

//croc.weight = 450;
//croc.speciesname = "Mugger Crocodile";
//croc.scientificname = "Crocodylus palustris";
//croc.length = 11;
//croc.isExtinct = false;
//croc.ExtinctStatus = "Vulnerable";
//croc.Lifespan = 70;
//croc.DisplayDetails();

//class Crocodile
//{
//    public int weight { get; set; }

//    public string speciesname { get; set; }
//    public string scientificname { get; set; }
//    public double length { get; set; }
//    public bool isExtinct { get; set; }
//    public string ExtinctStatus { get; set; }
//    public int Lifespan { get; set; }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Species Name: {speciesname}");
//        Console.WriteLine($"Scientific Name: {scientificname}");
//        Console.WriteLine($"Weight: {weight} kg");
//        Console.WriteLine($"Length: {length} feet");
//        Console.WriteLine($"Is Extinct: {isExtinct}");
//        Console.WriteLine($"Extinct Status: {ExtinctStatus}");
//        Console.WriteLine($"Lifespan: {Lifespan} years");
//    }
//}

Console.Write("Enter the number of crocodiles to collect: ");
int n = int.Parse(Console.ReadLine());

CrocodileCollection crocodileCollection = new CrocodileCollection();
crocodileCollection.CollectNCrocodiles(n);
crocodileCollection.DisplayNCrocodiles();
class Crocodile
{
    public int weight { get; set; }
    public string speciesname { get; set; }
    public string scientificname { get; set; }
    public double length { get; set; }
    public bool isExtinct { get; set; }
    public string ExtinctStatus { get; set; }
    public int Lifespan { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Species Name: {speciesname}");
        Console.WriteLine($"Scientific Name: {scientificname}");
        Console.WriteLine($"Weight: {weight} kg");
        Console.WriteLine($"Length: {length} feet");
        Console.WriteLine($"Is Extinct: {isExtinct}");
        Console.WriteLine($"Extinct Status: {ExtinctStatus}");
        Console.WriteLine($"Lifespan: {Lifespan} years");
    }

    public static Crocodile CollectCrocodileDetails()
    {
        Crocodile croc = new Crocodile();
        Console.WriteLine("Enter details for the crocodile:");
        Console.Write("Weight (kg): ");
        croc.weight = int.Parse(Console.ReadLine());
        Console.Write("Species Name: ");
        croc.speciesname = Console.ReadLine();
        Console.Write("Scientific Name: ");
        croc.scientificname = Console.ReadLine();
        Console.Write("Length (feet): ");
        croc.length = double.Parse(Console.ReadLine());
        Console.Write("Is Extinct (true/false): ");
        croc.isExtinct = bool.Parse(Console.ReadLine());
        Console.Write("Extinct Status: ");
        croc.ExtinctStatus = Console.ReadLine();
        Console.Write("Lifespan (years): ");
        croc.Lifespan = int.Parse(Console.ReadLine());
        return croc;
    }

    public static bool CheckCrocodileDetails(Crocodile croc)
    {
        if (croc.weight <= 0 || string.IsNullOrEmpty(croc.speciesname) || string.IsNullOrEmpty(croc.scientificname) ||
            croc.length <= 0 || string.IsNullOrEmpty(croc.ExtinctStatus) || croc.Lifespan <= 0)
        {
            return false;
        }
        return true;
    }
}

class CrocodileCollection
{
    private List<Crocodile> crocodiles = new List<Crocodile>();

    public void CollectNCrocodiles(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nCollecting details for crocodile {i + 1}:");
            Crocodile croc = Crocodile.CollectCrocodileDetails();
            while (!Crocodile.CheckCrocodileDetails(croc))
            {
                Console.WriteLine("Invalid details entered. Please re-enter the details for the crocodile.");
                croc = Crocodile.CollectCrocodileDetails();
            }
            crocodiles.Add(croc);
        }
    }

    public void DisplayNCrocodiles()
    {
        if (crocodiles == null || crocodiles.Count == 0)
        {
            Console.WriteLine("No crocodiles to display.");
            return;
        }
        for (int i = 0; i < crocodiles.Count; i++)
        {
            Console.WriteLine($"\nDetails of crocodile {i + 1}:");
            crocodiles[i].DisplayDetails();
        }
    }
}
