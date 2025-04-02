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
#region Automatic Rank Calculation
//int numStudents = 5;
//int numSubjects = 5;
//string[] subjects = { "Maths", "Science", "English", "Social", "History" };
//string[] studentNames = { "Arya", "Vishal", "Aditya", "Ananya", "Sandeep", "Bhargav", "Siddu", "Sai" };
//int[] stuTot = new int[numStudents];
//double[] stuAvg = new double[numStudents];
//List<int[]> marksList = new List<int[]>();
//Random random = new Random();

//List<string> selectedNames = new List<string>();
//while (selectedNames.Count < numStudents)
//{
//    string randomName = studentNames[random.Next(studentNames.Length)];
//    if (!selectedNames.Contains(randomName))
//    {
//        selectedNames.Add(randomName);
//    }
//}

//int studentIndex = 0;
//while (studentIndex < numStudents)
//{
//    int[] marks = new int[numSubjects];
//    Console.WriteLine($"Generating marks for {selectedNames[studentIndex]}:");
//    int subjectIndex = 0;
//    while (subjectIndex < numSubjects)
//    {
//        marks[subjectIndex] = random.Next(0, 101);
//        Console.WriteLine($"{subjects[subjectIndex]}: {marks[subjectIndex]}");
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
//    Console.WriteLine($"{selectedNames[studentIndex]} - Total: {stuTot[studentIndex]}, Average: {stuAvg[studentIndex]:F2}");
//    studentIndex++;
//}

//Console.WriteLine($"Highest Average: {highestAverage:F2}");
//Console.WriteLine($"Class Total: {classTotal}");
//Console.WriteLine($"Class Average: {classAverage:F2}");
#endregion

#region Functions
//int addtwo(int a,int b)
//{
//    return a + b;
//}
//var result = addtwo(10, 20);
//Console.WriteLine(result);

#endregion

#region Calculator

//void PrintWelcomeMessage()
//{
//    Console.WriteLine("===================================");
//    Console.WriteLine("       Welcome to Calculator       ");
//    Console.WriteLine("===================================");
//}

//void PrintGoodbyeMessage()
//{
//    Console.WriteLine("===================================");
//    Console.WriteLine("   Thank you for using Calculator  ");
//    Console.WriteLine("===================================");
//}

//double Add(double a, double b)
//{
//    double result = a + b;
//    Console.WriteLine($"Debug: Adding {a} and {b} to get {result}");
//    return result;
//}

//double Subtract(double a, double b)
//{
//    double result = a - b;
//    Console.WriteLine($"Debug: Subtracting {b} from {a} to get {result}");
//    return result;
//}

//double Multiply(double a, double b)
//{
//    double result = a * b;
//    Console.WriteLine($"Debug: Multiplying {a} and {b} to get {result}");
//    return result;
//}

//double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        Console.WriteLine("Debug: Division by zero detected. Returning 0.");
//        return 0;
//    }
//    double result = a / b;
//    Console.WriteLine($"Debug: Dividing {a} by {b} to get {result}");
//    return result;
//}

//void PerformCalculation()
//{
//    Console.WriteLine("\nEnter first number:");
//    double num1;
//    while (!double.TryParse(Console.ReadLine(), out num1))
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//    }

//    Console.WriteLine("Enter second number:");
//    double num2;
//    while (!double.TryParse(Console.ReadLine(), out num2))
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//    }

//    Console.WriteLine("Choose an operation (+, -, *, /):");
//    string operation = Console.ReadLine();

//    double result = 0;
//    bool validOperation = true;

//    switch (operation)
//    {
//        case "+":
//            result = Add(num1, num2);
//            break;
//        case "-":
//            result = Subtract(num1, num2);
//            break;
//        case "*":
//            result = Multiply(num1, num2);
//            break;
//        case "/":
//            result = Divide(num1, num2);
//            break;
//        default:
//            validOperation = false;
//            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
//            break;
//    }

//    if (validOperation)
//    {
//        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
//    }
//}

//PrintWelcomeMessage();

//while (true)
//{
//    PerformCalculation();

//    Console.WriteLine("\nDo you want to perform another calculation? (yes/no)");
//    string continueCalc = Console.ReadLine().ToLower();
//    if (continueCalc != "yes")
//    {
//        break;
//    }
//}

//PrintGoodbyeMessage();
#endregion

#region shop

void PrintWelcomeMessage()
{
    Console.WriteLine("===================================");
    Console.WriteLine("       Welcome to the Store        ");
    Console.WriteLine("===================================");
}

void PrintGoodbyeMessage()
{
    Console.WriteLine("===================================");
    Console.WriteLine("  Thank you for visiting the Store ");
    Console.WriteLine("===================================");
}

void PrintMainMenu()
{
    Console.WriteLine("\nWho are you?");
    Console.WriteLine("1. Customer");
    Console.WriteLine("2. Shop Owner");
    Console.WriteLine("3. Exit");
}

void PrintCustomerMenu()
{
    Console.WriteLine("\nCustomer Menu:");
    Console.WriteLine("1. View Products");
    Console.WriteLine("2. Add to Cart");
    Console.WriteLine("3. View Cart");
    Console.WriteLine("4. Checkout");
    Console.WriteLine("5. Back to Main Menu");
}

void PrintShopOwnerMenu()
{
    Console.WriteLine("\nShop Owner Menu:");
    Console.WriteLine("1. View Stock");
    Console.WriteLine("2. Update Stock");
    Console.WriteLine("3. Add New Products");
    Console.WriteLine("4. Update Prices");
    Console.WriteLine("5. Back to Main Menu");
}

void ViewStock(string[] products, int[] stock, double[] prices, int productCount)
{
    Console.WriteLine("\nCurrent Stock:");
    for (int i = 0; i < productCount; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i]} - ₹{prices[i]:F2} - Stock: {stock[i]}");
    }
}

void AddToCart(string[] products, int[] stock, double[] prices, int productCount, ref string[] cartProducts, ref int[] cartQuantities, ref double[] cartPrices, ref int cartCount)
{
    ViewStock(products, stock, prices, productCount);
    Console.WriteLine("\nEnter the product number to add to cart:");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.WriteLine($"Enter the quantity of {products[productNumber]} to add to cart:");
        int quantity = int.Parse(Console.ReadLine());
        if (quantity > 0 && quantity <= stock[productNumber])
        {
            int newSize = cartCount + 1;
            string[] newCartProducts = new string[newSize];
            int[] newCartQuantities = new int[newSize];
            double[] newCartPrices = new double[newSize];

            for (int i = 0; i < cartCount; i++)
            {
                newCartProducts[i] = cartProducts[i];
                newCartQuantities[i] = cartQuantities[i];
                newCartPrices[i] = cartPrices[i];
            }

            newCartProducts[cartCount] = products[productNumber];
            newCartQuantities[cartCount] = quantity;
            newCartPrices[cartCount] = prices[productNumber];

            cartProducts = newCartProducts;
            cartQuantities = newCartQuantities;
            cartPrices = newCartPrices;
            cartCount = newSize;

            Console.WriteLine($"{quantity} {products[productNumber]}(s) added to cart.");
        }
        else
        {
            Console.WriteLine("Invalid quantity or out of stock.");
        }
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

void ViewCart(string[] cartProducts, int[] cartQuantities, double[] cartPrices, int cartCount)
{
    if (cartCount == 0)
    {
        Console.WriteLine("\nYour cart is empty. Keep shopping!");
    }
    else
    {
        Console.WriteLine("\nShopping Cart:");
        double total = 0;
        for (int i = 0; i < cartCount; i++)
        {
            double itemTotal = cartQuantities[i] * cartPrices[i];
            Console.WriteLine($"{i + 1}. {cartProducts[i]} - ₹{cartPrices[i]:F2} x {cartQuantities[i]} = ₹{itemTotal:F2}");
            total += itemTotal;
        }
        Console.WriteLine($"Total: ₹{total:F2}");
    }
}

void Checkout(ref string[] cartProducts, ref int[] cartQuantities, ref double[] cartPrices, ref int cartCount, int[] stock, string[] products)
{
    if (cartCount == 0)
    {
        Console.WriteLine("\nYour cart is empty. Keep shopping!");
        return;
    }

    double total = 0;
    for (int i = 0; i < cartCount; i++)
    {
        total += cartQuantities[i] * cartPrices[i];
    }
    Console.WriteLine($"\nYour total is ₹{total:F2}. Do you want to proceed to checkout? (yes/no)");
    string choice = Console.ReadLine().ToLower();
    if (choice == "yes")
    {
        for (int i = 0; i < cartCount; i++)
        {
            for (int j = 0; j < products.Length; j++)
            {
                if (cartProducts[i] == products[j])
                {
                    stock[j] -= cartQuantities[i];
                    break;
                }
            }
        }
        Console.WriteLine("Checkout successful!");
        cartProducts = new string[0];
        cartQuantities = new int[0];
        cartPrices = new double[0];
        cartCount = 0;
    }
    else
    {
        Console.WriteLine("Checkout canceled.");
    }
}

void UpdateStock(string[] products, int[] stock, int productCount)
{
    ViewStock(products, stock, new double[productCount], productCount);
    Console.WriteLine("\nEnter the product number to update stock:");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.WriteLine($"Enter the new stock quantity for {products[productNumber]}:");
        int newStock = int.Parse(Console.ReadLine());
        if (newStock >= 0)
        {
            stock[productNumber] = newStock;
            Console.WriteLine($"Stock updated for {products[productNumber]} to {newStock}");
        }
        else
        {
            Console.WriteLine("Invalid stock quantity.");
        }
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

void AddNewProducts(ref string[] products, ref int[] stock, ref double[] prices, ref int productCount)
{
    Console.WriteLine("\nEnter the name of the new product:");
    string newProduct = Console.ReadLine();
    Console.WriteLine("Enter the price of the new product:");
    double newPrice = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the stock quantity of the new product:");
    int newStock = int.Parse(Console.ReadLine());

    int newSize = productCount + 1;
    string[] newProducts = new string[newSize];
    int[] newStockArray = new int[newSize];
    double[] newPrices = new double[newSize];

    for (int i = 0; i < productCount; i++)
    {
        newProducts[i] = products[i];
        newStockArray[i] = stock[i];
        newPrices[i] = prices[i];
    }

    newProducts[productCount] = newProduct;
    newStockArray[productCount] = newStock;
    newPrices[productCount] = newPrice;

    products = newProducts;
    stock = newStockArray;
    prices = newPrices;
    productCount = newSize;

    Console.WriteLine($"New product {newProduct} added with price ₹{newPrice:F2} and stock {newStock}");
}

void UpdatePrices(string[] products, double[] prices, int productCount)
{
    ViewStock(products, new int[productCount], prices, productCount);
    Console.WriteLine("\nEnter the product number to update price:");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.WriteLine($"Enter the new price for {products[productNumber]}:");
        double newPrice = double.Parse(Console.ReadLine());
        if (newPrice >= 0)
        {
            prices[productNumber] = newPrice;
            Console.WriteLine($"Price updated for {products[productNumber]} to ₹{newPrice:F2}");
        }
        else
        {
            Console.WriteLine("Invalid price.");
        }
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

void CustomerMenu(string[] products, int[] stock, double[] prices, int productCount)
{
    string[] cartProducts = new string[0];
    int[] cartQuantities = new int[0];
    double[] cartPrices = new double[0];
    int cartCount = 0;

    while (true)
    {
        PrintCustomerMenu();
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            ViewStock(products, stock, prices, productCount);
        }
        else if (choice == 2)
        {
            AddToCart(products, stock, prices, productCount, ref cartProducts, ref cartQuantities, ref cartPrices, ref cartCount);
        }
        else if (choice == 3)
        {
            ViewCart(cartProducts, cartQuantities, cartPrices, cartCount);
        }
        else if (choice == 4)
        {
            Checkout(ref cartProducts, ref cartQuantities, ref cartPrices, ref cartCount, stock, products);
        }
        else if (choice == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}

void ShopOwnerMenu(ref string[] products, ref int[] stock, ref double[] prices, ref int productCount)
{
    while (true)
    {
        PrintShopOwnerMenu();
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            ViewStock(products, stock, prices, productCount);
        }
        else if (choice == 2)
        {
            UpdateStock(products, stock, productCount);
        }
        else if (choice == 3)
        {
            AddNewProducts(ref products, ref stock, ref prices, ref productCount);
        }
        else if (choice == 4)
        {
            UpdatePrices(products, prices, productCount);
        }
        else if (choice == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}

PrintWelcomeMessage();

string[] products = { };
int[] stock = { };
double[] prices = { };
int productCount = 0;

while (true)
{
    PrintMainMenu();
    int roleChoice = int.Parse(Console.ReadLine());
    if (roleChoice == 1)
    {
        CustomerMenu(products, stock, prices, productCount);
    }
    else if (roleChoice == 2)
    {
        ShopOwnerMenu(ref products, ref stock, ref prices, ref productCount);
    }
    else if (roleChoice == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

PrintGoodbyeMessage();
#endregion