class SalesCommission
{
    static void Main(string[] args)
    {
        // declaring variables
        string? salesManName;
        int numberOfItems = 0;
        decimal itemPrice;
        decimal total = 0;
        int pay = 200;
        decimal commission = 0.09M;

        // want to add more items
        int moreItem = 0;

        // input name
        Console.Write("Enter Your Name:  ");
        salesManName = Console.ReadLine();

        do
        {
            // incrementing in number of items
            numberOfItems = numberOfItems + 1;

            if (moreItem == 1)
            {
                // input price of item
                Console.Write("\nEnter Price Of Item " + numberOfItems + ":  ");
                itemPrice = Convert.ToDecimal(Console.ReadLine());

                total += itemPrice;
            }

            else
            {
                // input price of item
                Console.Write("Enter Price Of Item " + numberOfItems + ":  ");
                itemPrice = Convert.ToDecimal(Console.ReadLine());

                total += itemPrice;
            }

            Console.WriteLine();    // just for spacing purpose

            // want to continue adding items or end the loop
            Console.Write("Want To Add More Items, Enter 1 Or To Exit Enter 0 :  ");
            moreItem = Convert.ToInt32(Console.ReadLine());

        } while (moreItem == 1);

        Console.WriteLine();    // just for spacing purpose

        // displaying name of the sales man
        Console.WriteLine("Salesman Name: " + salesManName);

        // displaying number of items sold
        Console.WriteLine("Number Of Items Sold:  " + numberOfItems);

        // displaying total price of items sold
        Console.WriteLine("Total Price Of Items Sold:  " + total + "$");

        // total pay
        Console.WriteLine("Total Pay: " + (pay + (total * commission)) + "$");
    }
}
