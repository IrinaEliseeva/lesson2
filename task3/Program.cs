// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
public class Program {
    public static void Main(){
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 1 || num >7)
        {
            Console.WriteLine("неверный день недели");
        } else {

            Console.WriteLine(num == 6 || num == 7 ? "да" : "нет");
        }
    }
}