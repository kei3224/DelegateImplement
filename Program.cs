namespace DelegateExampleLesson1
{
    //1. first create a delegate
    public delegate double Operation(double x, double y);

    public class Program
    {
        //2. create a static method to be referenced to delegate in main method
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static void Main(string[] args)
        {
            //3. create a variable for the reference type delegate which is an implemetation of Abstraction
            Operation addOperation = Add;
            double num1 = 10.5;
            double num2 = 12.3;

            //pass values to the static method Add
            double result = addOperation(num1, num2);

            Console.WriteLine(result);

        }
    }
}