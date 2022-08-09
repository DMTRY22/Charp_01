// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 Console.Write("12;");

 int numberA = Convert.ToInt32(Console.ReadLine());

 Console.Write("5;");

 int numberB = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(numberA > numberB);

 {
    Console.WriteLine("12" + numberA + "5" + numberB);
}
{
    Console.WriteLine("5" + numberB + "12" + numberA);
}
Console.WriteLine();