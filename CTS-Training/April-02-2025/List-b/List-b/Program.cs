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


Console.WriteLine("Hello World!");
List<string> names = new List<string>();
List<int> numbers = new List<int>();


names.Add("Sandeep");
names.Add("Vishal");
names.Add("Sachin");

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
int countofnames = 0;
int CalCount(List<string> names)
{
    for (int i = 0; i < 100; i++)
    {
        try
        {
            if (names[i] != null)
            {
                countofnames++;
            }
        }
        catch (Exception ex)
        {
        }
    }
    return countofnames;
}
int CalNum(List<int> numbers)
{
    int countofnumbers = 0;
    for (int i = 0; i < 100; i++)
    {
        try
        {
            if (numbers[i] != 0)
            {
                countofnumbers++;
            }
        }
        catch (Exception ex)
        {
        }
    }
    return countofnumbers;
}

int countnames = CalCount(names);
Console.WriteLine("Count Names:" +countnames);
int countnumbers = CalNum(numbers);
Console.WriteLine("Count Numbers:"+ countnumbers);

Console.WriteLine();
for (int i = 0; i < countnames; i++)
{
    Console.WriteLine(names[i]);
}

for (int i = 0; i < countnumbers; i++)
{
    Console.WriteLine(numbers[i]);
}
