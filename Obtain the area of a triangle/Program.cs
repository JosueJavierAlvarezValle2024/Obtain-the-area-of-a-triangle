
class Program
{
    static void Main()
    {
        double Base = 0, Height = 0;

        Console.WriteLine("To obtain the area of a triangle you will have to enter the base and the height of the triangle.");
        Console.WriteLine();

        Base = ReadDouble("Length");
        Height = ReadDouble("Width");

        double Area = (Base * Height) / 2;
        Console.WriteLine("The area is: " + Area); // In this line the operation is done to take out the area of the triangle.
        Console.ReadLine();
    }

    static double ReadDouble(string prompt)
    {
        double value;
        bool validInput = false;

        do
        {
            Console.Write(prompt + ": ");
            string input = Console.ReadLine();
            validInput = double.TryParse(input, out value);

            if (!validInput)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } while (!validInput);

        return value;
    }
}