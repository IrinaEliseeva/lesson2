// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
public class Program {
    public static void Main(){
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 100)
        {
            Console.WriteLine("третьей цифры нет");
        } else {
            while (num >= 1000) {
                num = num / 10;
            }
            Console.WriteLine(num % 10);
        }
    }
}