
// Здравствуйте) Я получается сделала 6 задач и вот эту итоговую.МНе продлить дедлайн,чтобы закрыть задачу 7 и 8?Это очень важно?Это будет влиять на баллы и результат?
// Задача 1.

System.Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int NaturalElem(int num)
{
    if (num == 1)
    {
        return 1;
    }
    System.Console.WriteLine(num);
    return NaturalElem(num - 1);
}

System.Console.WriteLine(NaturalElem(num));


// Задача 2.

System.Console.Write("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int NaturalElem(int N, int M)
{
    // int sum = 0;
    if (N == M)
    {
        return M;
    }
    // sum= sum+N;
    return (N + NaturalElem(N - 1, M));
}

System.Console.WriteLine(NaturalElem(N, M));

// Задача 3.

System.Console.Write("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}
System.Console.WriteLine(Akkerman(M, N));
