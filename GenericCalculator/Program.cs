class Program
{
    public static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Calculator<double> doubleCalculator = new Calculator<double>();

        Console.WriteLine($"Addition: {intCalculator.Add(6, 7)}\n" +
                          $"Addition: {doubleCalculator.Add(20.5, 32.3)}\n" +
                          $"Subtract: {intCalculator.Subtract(8, 3)}\n" +
                          $"Multiply: {intCalculator.Multiply(10, 2)} \n" +
                          $"Division: {intCalculator.Divide(20, 4)} \n");
    }
}
