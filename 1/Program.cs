int n = Int32.Parse(Console.ReadLine());
if (n % 10 == n / 10000 && n % 100 / 10 == n / 1000 % 10)
    Console.WriteLine("Является палидромом");
else
    Console.WriteLine("Не является палиндромом");

