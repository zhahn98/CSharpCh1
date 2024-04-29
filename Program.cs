//Declare List of Products using <Product> class as a template. This specific list of items is titled "products"
List<Product> products = new List<Product>()
{
  new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false,
        //DateTime format: (YYYY, MM, DD)
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
  new Product()
    { 
        Name = "Basketball", 
        Price = 8, 
        Sold = false,
        StockDate = new DateTime(1984, 12, 25),
        ManufactureYear = 1980
    },
  new Product()
    { 
        Name = "Shoes", 
        Price = 195, 
        Sold = false,
        StockDate = new DateTime(2020, 1, 20),
        ManufactureYear = 2012
    },
  new Product()
    { 
        Name = "Shorts", 
        Price = 1, 
        Sold = true,
        StockDate = new DateTime(2022, 2, 22),
        ManufactureYear = 2022
    },
  new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false,
        StockDate = new DateTime(2017, 5, 15),
        ManufactureYear = 2015
    }
};

string greeting = @"Welcome to Thrown for a Loop,
Your one-stop shop for used sporting equipment!";

Console.WriteLine(greeting);
Console.WriteLine("Products:");

//Loop through products list and print the Name attribute of each one
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");

//Store user response as variable. Parse converts string response to int, and Trim removes excess spaces
int response = int.Parse(Console.ReadLine().Trim());

//Handles cases where the user is silly and tries to enter an invalid response
while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    //Redefine response until valid answer provided
    response = int.Parse(Console.ReadLine().Trim());
}

//Assign user response to ID of product. Subtract 1 because our list starts at 0
Product chosenProduct = products[response - 1];

//Set a variable that stores the current time
DateTime now = DateTime.Now;

//Calculates how long the product has been in stock by subtracting the stock date from the current time
TimeSpan timeInStock = now - chosenProduct.StockDate;

//Provide info on the chosen product
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
