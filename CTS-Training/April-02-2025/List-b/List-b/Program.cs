//List<string> names = new List<string>();

//names.Add("Sandeep");
//names.Add("Vishal");
//names.Add("Sachin");

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}
//Console.WriteLine();

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//} 


//Console.WriteLine("Hello World!");
//List<string> names = new List<string>();
//List<int> numbers = new List<int>();


//names.Add("Sandeep");
//names.Add("Vishal");
//names.Add("Sachin");

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);
//int countofnames = 0;
//int CalCount(List<string> names)
//{
//    for (int i = 0; i < 100; i++)
//    {
//        try
//        {
//            if (names[i] != null)
//            {
//                countofnames++;
//            }
//        }
//        catch (Exception ex)
//        {
//        }
//    }
//    return countofnames;
//}
//int CalNum(List<int> numbers)
//{
//    int countofnumbers = 0;
//    for (int i = 0; i < 100; i++)
//    {
//        try
//        {
//            if (numbers[i] != 0)
//            {
//                countofnumbers++;
//            }
//        }
//        catch (Exception ex)
//        {
//        }
//    }
//    return countofnumbers;
//}

//int countnames = CalCount(names);
//Console.WriteLine("Count Names:" +countnames);
//int countnumbers = CalNum(numbers);
//Console.WriteLine("Count Numbers:"+ countnumbers);

//Console.WriteLine();
//for (int i = 0; i < countnames; i++)
//{
//    Console.WriteLine(names[i]);
//}

//for (int i = 0; i < countnumbers; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{
    static void Main()
    {
        Console.WriteLine("Hello Jay!");

        List<string> names = new List<string>();
        List<int> numbers = new List<int>();

        Console.Write("Enter the number of names you want to input: ");
        int numNames = int.Parse(Console.ReadLine());

        for (int i = 0; i < numNames; i++)
        {
            Console.Write("Enter a name: ");
            names.Add(Console.ReadLine());
        }

        Console.Write("Enter the number of numbers you want to input: ");
        int numNumbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numNumbers; i++)
        {
            Console.Write("Enter a number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int countnames = names.Count;
        int countnumbers = numbers.Count;

        Console.WriteLine("Count Names: " + countnames);
        Console.WriteLine("Count Numbers: " + countnumbers);

        Console.WriteLine("\nNames:");
        for (int i = 0; i < countnames; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("\nNumbers:");
        for (int i = 0; i < countnumbers; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        StoreInputToFile(names, numbers);
        Console.WriteLine("Input has been stored in user_input.txt");
    }

    static void StoreInputToFile(List<string> names, List<int> numbers, string filename = "user_input.txt")
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine("Names:");
            foreach (var name in names)
            {
                file.WriteLine(name);
            }

            file.WriteLine("\nNumbers:");
            foreach (var number in numbers)
            {
                file.WriteLine(number);
            }
        }
    }
}