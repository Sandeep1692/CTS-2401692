// See https://aka.ms/new-console-template for more information
#region String Basics
//Console.WriteLine("Hello, Sandeep!");
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, Vishal!");
//Console.WriteLine("Welcome Team!");
//Console.WriteLine("Welcome to CTS");

//var team1 = "MI";
//var team2 = "KKR";
//int score = 9;
//Console.WriteLine(team1+ " Beat " + team2 + " by " + score + " runs");
#endregion
//Console.WriteLine();

#region Operators
//int a = 10;
//int b = 20;
//var add = a + b;
//var sub = a - b;
//var mul = a * b;
//var div = a / b;
//var mod = a % b;
//Console.WriteLine("Addition: " + add);
//Console.WriteLine("Subtraction: " + sub);
//Console.WriteLine("Multiplication: " + mul);
//Console.WriteLine("Division: " + div);
//Console.WriteLine("Modulus: " + mod);
#endregion

#region Rank Calculation
//int numStudents = 5;
//int numSubjects = 5;
//string[] subjects = { "Maths", "Science", "English", "Social", "Histroy" };
//int[] stuTot = new int[numStudents];
//double[] stuAvg = new double[numStudents];
//List<int[]> marksList = new List<int[]>();

//int studentIndex = 0;
//while (studentIndex < numStudents)
//{
//    int[] marks = new int[numSubjects];
//    Console.WriteLine($"Enter marks for Student {studentIndex + 1}:");
//    int subjectIndex = 0;
//    while (subjectIndex < numSubjects)
//    {
//        Console.Write($"{subjects[subjectIndex]}: ");
//        marks[subjectIndex] = int.Parse(Console.ReadLine());
//        subjectIndex++;
//    }
//    marksList.Add(marks);
//    studentIndex++;
//}

//studentIndex = 0;
//while (studentIndex < numStudents)
//{
//    int total = 0;
//    int[] marks = marksList[studentIndex];
//    int subjectIndex = 0;
//    while (subjectIndex < numSubjects)
//    {
//        total += marks[subjectIndex];
//        subjectIndex++;
//    }
//    stuTot[studentIndex] = total;
//    stuAvg[studentIndex] = total / (double)numSubjects;
//    studentIndex++;
//}

//double highestAverage = stuAvg[0];
//for (int i = 1; i < numStudents; i++)
//{
//    if (stuAvg[i] > highestAverage)
//    {
//        highestAverage = stuAvg[i];
//    }
//}

//int classTotal = 0;
//for (int i = 0; i < numStudents; i++)
//{
//    classTotal += stuTot[i];
//}
//double classAverage = classTotal / (double)(numStudents * numSubjects);

//studentIndex = 0;
//while (studentIndex < numStudents)
//{
//    Console.WriteLine($"Student {studentIndex + 1} - Total: {stuTot[studentIndex]}, Average: {stuAvg[studentIndex]:F2}");
//    studentIndex++;
//}

//Console.WriteLine($"Highest Average: {highestAverage:F2}");
//Console.WriteLine($"Class Total: {classTotal}");
//Console.WriteLine($"Class Average: {classAverage:F2}");

#endregion

int numStudents = 5;
int numSubjects = 5;
string[] subjects = { "Maths", "Science", "English", "Social", "History" };
string[] studentNames = { "Arya", "Vishal", "Aditya", "Ananya", "Sandeep", "Bhargav", "Siddu", "Sai" };
int[] stuTot = new int[numStudents];
double[] stuAvg = new double[numStudents];
List<int[]> marksList = new List<int[]>();
Random random = new Random();

List<string> selectedNames = new List<string>();
while (selectedNames.Count < numStudents)
{
    string randomName = studentNames[random.Next(studentNames.Length)];
    if (!selectedNames.Contains(randomName))
    {
        selectedNames.Add(randomName);
    }
}

int studentIndex = 0;
while (studentIndex < numStudents)
{
    int[] marks = new int[numSubjects];
    Console.WriteLine($"Generating marks for {selectedNames[studentIndex]}:");
    int subjectIndex = 0;
    while (subjectIndex < numSubjects)
    {
        marks[subjectIndex] = random.Next(0, 101);
        Console.WriteLine($"{subjects[subjectIndex]}: {marks[subjectIndex]}");
        subjectIndex++;
    }
    marksList.Add(marks);
    studentIndex++;
}

studentIndex = 0;
while (studentIndex < numStudents)
{
    int total = 0;
    int[] marks = marksList[studentIndex];
    int subjectIndex = 0;
    while (subjectIndex < numSubjects)
    {
        total += marks[subjectIndex];
        subjectIndex++;
    }
    stuTot[studentIndex] = total;
    stuAvg[studentIndex] = total / (double)numSubjects;
    studentIndex++;
}

double highestAverage = stuAvg[0];
for (int i = 1; i < numStudents; i++)
{
    if (stuAvg[i] > highestAverage)
    {
        highestAverage = stuAvg[i];
    }
}

int classTotal = 0;
for (int i = 0; i < numStudents; i++)
{
    classTotal += stuTot[i];
}
double classAverage = classTotal / (double)(numStudents * numSubjects);

studentIndex = 0;
while (studentIndex < numStudents)
{
    Console.WriteLine($"{selectedNames[studentIndex]} - Total: {stuTot[studentIndex]}, Average: {stuAvg[studentIndex]:F2}");
    studentIndex++;
}

Console.WriteLine($"Highest Average: {highestAverage:F2}");
Console.WriteLine($"Class Total: {classTotal}");
Console.WriteLine($"Class Average: {classAverage:F2}");