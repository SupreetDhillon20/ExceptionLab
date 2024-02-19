namespace ExceptionLab
{
    public class Circle
    {
        public double radius;

        public Circle()
        {
            radius = 0;
        }

        public void SetRadius(double r)
        {
            if (r > 0)
            {
                radius = r;
            }
            else
            {
                throw new InvalidRadiusException(r);
            }
        }

        public override string ToString()
        {
            return $"Radius of circle: {radius}";
        }
    }

    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException()
        {
            Console.WriteLine("Invalid radius. Radius must be greater than zero.");
        }

        public InvalidRadiusException(double radius)
        {
            Console.WriteLine($"Invalid radius: {radius}. Radius must be greater than zero.");
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write($"Write a positive number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Circle circle1 = new Circle();
                circle1.SetRadius(num1);
                Console.WriteLine(circle1);

                Console.Write($"Write a zero or negative number to get error: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Circle circle2 = new Circle();
                circle2.SetRadius(num2); // This will throw InvalidRadiusException
                Console.WriteLine(circle2);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
