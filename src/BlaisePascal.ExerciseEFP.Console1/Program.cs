public class Program //this is a class
{
    //method of entry for the exxecution of the code 
    public static void Main()
    {
        Console.WriteLine("welcome to Easy Library!");

        Console.WriteLine("To start, insert your full name.");
        string fullName = Console.ReadLine();

        Console.WriteLine("now, insert the number of books that you are ordering.");
        int numeberOfBooks = int.Parse(Console.ReadLine());

        Console.WriteLine("Now, insert price of a single book");
        int priceSingleBook = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert the type of shipping (Shipping or Retrieve).");
        string shippingType = Console.ReadLine();
        if (shippingType == "Shipping" || shippingType == "shipping")
        {
            int totalPrice = numeberOfBooks * priceSingleBook + 5;
            Console.WriteLine($"Dear {fullName}, your order has been succesfull, the total price is {totalPrice}$.");
            int daysRetrieve = Random.Shared.Next(1, 8);
            Console.WriteLine($"What's the adress you want to ship this order to?");
            Console.WriteLine("Thank you for your order!");
        }
        else if (shippingType == "Retrieve" || shippingType == "retrieve")
        {
            int totalPrice = numeberOfBooks * priceSingleBook;
            Console.WriteLine($"Dear {fullName}, your order has been succesfull, the total price is {totalPrice}$.");
            int daysRetrieve = Random.Shared.Next(1, 8);
            Console.WriteLine($"Your order will be ready for retrieval in {daysRetrieve} days");
            Console.WriteLine("Thank you for your order!");
        }
        else
        {
            Console.WriteLine("Invalid shipping type. The order has not been placed");
        }


    }
}