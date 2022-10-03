do
{
    Console.WriteLine("В какую программу вы хотите зайти?");
    Console.WriteLine("1. Угадай число.");
    Console.WriteLine("2. Таблица умножения от 1 до 10");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выход из программы");
    int p = Convert.ToInt32(Console.ReadLine());

    void ugad()
    {
        int a = 0, n = 0;
        Random r = new Random();
        n = r.Next(1, 100);
        while (n != a)
        {
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            if (n == a) { Console.WriteLine("Вы победили"); }
            else if (a < n) { Console.WriteLine("Надо было больше"); }
            else if (a > n) { Console.WriteLine("Надо было меньше"); }
        }

    }
    void tabl()
    {
        int[,] ta = new int[10, 10];
        int[] ta1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        for (int i = 1; i < ta.GetLength(0); ++i)
        {
            for (int j = 1; j < ta.GetLength(1); ++j)
            {
                int sum = i * j;
                if (i == j)
                {
                    ta[i, j] = sum;
                    Console.Write(ta[i, j] + "\t");
                }
                else if (i > j)
                {
                    ta[i, j] = sum;
                    Console.Write(ta[i, j] + "\t");
                }
                else if (i < j)
                {
                    ta[i, j] = sum;
                    Console.Write(ta[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
    void del()
    {
        int i = 0;
        Console.WriteLine("Введите число:");
        int c = Convert.ToInt32(Console.ReadLine());
        while (i <= c)
        {
            i++;
            if (c % i == 0)
                Console.WriteLine("Число {0} делится без остатка на {1}", c, i);
        }
    }
    void exit()
    {
        Environment.Exit(0);
    }
    switch (p)
    {
        case 1:
            ugad();
            break;
        case 2:
            tabl();
            break;
        case 3:
            del();
            break;
        case 4:
            exit();
            break;
    }
} while (true);
