public class Program //this is a class
{
    //method of entry for the exxecution of the code 
    public static void Main()
    {
        Console.WriteLine("welcome to Easy Library!");

        Console.WriteLine("To start, insert your full name.");
        string fullName = Console.ReadLine();

        Console.WriteLine("now, insert the number of books that you are ordering.");
        int numberOfBooks = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine("Now, insert price of a single book");
        int priceSingleBook = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine("Are you a student?");
        string student = Console.ReadLine().ToLower();

        int discount = 10; // Set the discount percentage for students

        Console.WriteLine("Please insert the type of shipping (Shipping or Retrieve).");
        string shippingType = Console.ReadLine().ToLower();

        if (shippingType == "shipping")
        {
            int totalPrice = numberOfBooks * priceSingleBook;
            if (student == "yes")
            {
                Console.WriteLine($"The subtotal is {totalPrice}$."); // Display the total price before discounts and shipping
                totalPrice = totalPrice - (totalPrice * discount / 100);
            }
            Console.WriteLine($"Dear {fullName}, your order has been succesfully placed.\nThe total price is {totalPrice}$.\nWith the shipping fee it will be {totalPrice + 5}$.");
            // Display the total price after discounts and shipping

            int daysRetrieve = Random.Shared.Next(1, 8);

            Console.WriteLine($"What's the adress you want to ship this order to?");//to get an adress from the user then add an estimated time of shipment
            string adress = Console.ReadLine();

            Console.WriteLine($"Your order will be shipped to you in {daysRetrieve} working days at {adress}.");
            Console.WriteLine($"Thank you for your order of {numberOfBooks} books!");
        }

        else if (shippingType == "retrieve")
        {
            int totalPrice = numberOfBooks * priceSingleBook;
            if (student == "yes")
            {
                Console.WriteLine($"The subtotalis {totalPrice}$."); // Display the total price before discounts
                totalPrice = totalPrice - (totalPrice * discount / 100);
            }
            Console.WriteLine($"Dear {fullName}, your order has been succesfully placed.\nThe total price is {totalPrice}$."); // Display the total price after discounts

            int daysRetrieve = Random.Shared.Next(1, 8);
            Console.WriteLine($"Your order will be ready for retrieval in {daysRetrieve} working days");// Display the estimated time for retrieval
            Console.WriteLine($"Thank you for your order of {numberOfBooks} books!");
        }

        else
        {
            Console.WriteLine("Invalid shipping type. The order has not been placed");
        }

    }

}