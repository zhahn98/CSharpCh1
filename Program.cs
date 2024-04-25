﻿List<Product> products = new List<Product>()
{
  new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false
    },
  new Product()
    { 
        Name = "Basketball", 
        Price = 8, 
        Sold = false
    },
  new Product()
    { 
        Name = "Shoes", 
        Price = 195, 
        Sold = false
    },
  new Product()
    { 
        Name = "Shorts", 
        Price = 1, 
        Sold = true
    },
  new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false
    }
};

string greeting = @"Welcome to Thrown for a Loop,
Your one-stop shop for used sporting equipment!";

Console.WriteLine(greeting);
Console.WriteLine("Products:");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");

