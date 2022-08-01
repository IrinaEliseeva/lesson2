// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
public class Program {
    public static void Main(){
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 100 || num > 999)
        {
            Console.WriteLine("input number should be between 100 and 999");
        } else {
            Console.WriteLine(num / 10 % 10);
        }
    }
}