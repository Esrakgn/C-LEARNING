/*
string name = "Esra";
int age = 22;
double height = 1.60;
bool isAlive = true;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);

Console.WriteLine("Is Alive?" + isAlive);
*/


/*
int studentGrade = 85;
if (studentGrade >= 50)
{
     Console.WriteLine("Congratulations! You passed the exam.");
}
else
{
     Console.WriteLine("Sorry, you failed the exam. Better luck next time!");

}
*/


/*
// ----Logical Operators----

using System.ComponentModel.Design;

string username = "admin";
string password = "123";

if ( username == "admin" && password == "123") 
{
    Console.WriteLine("Login succesfull");
}
else
{
    Console.WriteLine("Login Failed");
}

*/


/*
bool isStudent = false;
int age = 70;

if (isStudent == true || age > 65)
{
    Console.WriteLine("You get a discount!");
}
else
{
    Console.WriteLine("Redular price");
}

*/


/*
bool hasKey = true;
bool knowsPassword = false;

if (hasKey || knowsPassword)
{
    Console.WriteLine("Welcome!!");
}
else
{
     Console.WriteLine("Access Denied");
}

*/


/*
int temperature = 25;

if (temperature > 30)
{
    Console.WriteLine("Hot");
}
else if (temperature >= 15 && temperature <= 30)
{
    Console.WriteLine("The weather is perfect.");
}
else
{
    Console.WriteLine("Cold");
}

*/


/*
// -----DENEME ÜRÜN VE KDV HESAPLAMA-----

string productName = "Coffe Machine";
decimal price = 100.00m;   
double taxtRate = 0.20;
int quantity = 2;

//C#'a double ve decimal'ın birlikte çalışmasının sorunsuz olduğunu (decimal) kullanarak belirtmemiz gerekiyor.

decimal totalTax = price * (decimal)taxtRate;
decimal finalPricePerUnit = price + totalTax;
decimal grandTotal = finalPricePerUnit * quantity;

Console.WriteLine($"Product: {productName}");
Console.WriteLine($"Price per unit: {price:C}");
Console.WriteLine($"Tax per unit: {totalTax:C}");
Console.WriteLine($"Quantity: {quantity}");

Console.WriteLine($"GRAND TOTAL: {grandTotal}");

*/

/*
//----READLINE------

Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Nice to meet you, {userName}");

*/


/*

Console.WriteLine("How many pizzas do you want to order?");

string input = Console.ReadLine();
int quantity = Convert.ToInt32(input);

int totalprice = quantity * 150;

Console.WriteLine($"Total price for {quantity} pizzas is: {totalprice} TL");

*/


/*
Console.WriteLine("Which city are you from?");
string city = Console.ReadLine();
Console.WriteLine("How many days will you stay there?");
string daysInput = Console.ReadLine();
int days = Convert.ToInt32(daysInput);
Console.WriteLine($"Oh, {city} is beautiful! You have {days * 24} hours to explore it.");
*/


/*
Console.WriteLine("Enter a number:");
int myNumber = int.Parse(Console.ReadLine());

myNumber++;
Console.WriteLine($"After increment (++): {myNumber}");

if (myNumber  % 2 == 0) 
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd");
}
*/



//----ARRAY-----

/*
string[] gamingConsoles = { "PS5", "Xbox", "Switch", "PC" };
for (int i = 0; i < gamingConsoles.Length; i++)
{
    Console.WriteLine(gamingConsoles[i]);
}
*/

/*
string[] cities = { "Istanbul", "Ankara", "Izmir", "Bursa", "Antalya"};
foreach (string city in cities)
{
    Console.WriteLine(city);
}

*/


// ----LIST-----

/*
List<string> shoppingCart = new List<string>();

// Veri Ekleme (Add)
shoppingCart.Add("Laptop");
shoppingCart.Add("Mouse");
shoppingCart.Add("Keyboard");


//Veri Kontrolü (Contains)
bool hasMouse = shoppingCart.Contains("Mouse");
//Console.WriteLine($"Is Mouse in the shopping cart? {hasMouse}");


//Veri Silme (Remove)
shoppingCart.Remove("Keyboard");
foreach (string item in shoppingCart) 
{
    Console.WriteLine(item);
}

//Belirli Bir Konumda Veri Silme (RemoveAt)
shoppingCart.RemoveAt(1);
foreach (string item in shoppingCart)
{
    Console.WriteLine(item);
}

// Listeyi Temizleme (Clear)
shoppingCart.Clear();
foreach (string item in shoppingCart)
{
    Console.WriteLine(item);
}

*/

/*
List<string> customerNames = new List<string>();

customerNames.Add("Esra");
customerNames.Add("Melih");
customerNames.Add("Ayse");

if (customerNames.Contains("Esra"))
{
    customerNames.Remove("Esra");
}

Console.WriteLine("Customer names: ");

foreach(string customer in customerNames)
{
    Console.WriteLine(customer);
}
*/

/*

class Program
{
    // İŞTE O EKSİK OLAN GİRİŞ KAPISI:
    static void Main(string[] args)
    {
        // 1. Önce senin yazdığın MyMethod sınıfından bir nesne üretelim
        MyMethod helper = new MyMethod();

        // 2. Metodunu çağıralım
        helper.SayHello("Esra");

        // 3. Konsolun hemen kapanmaması için bir tuş bekleyelim
        Console.WriteLine("\nProgram başarıyla çalıştı. Çıkmak için bir tuşa bas...");
        Console.ReadKey();
    }
}


*/



//----METHODS----

/*
class MyMethod
{
    static void main()
    {
        sayHello();
    }


    static void sayHello() 
    {
        Console.WriteLine("Hello, World!");
    }


}

*/


/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Program started");
    }
}

*/




