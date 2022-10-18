//Zadacha64();

void Zadacha64()
{
    Console.WriteLine("Введите число N :");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число M :");
    int m = Convert.ToInt32(Console.ReadLine());
    FindNatural(n, m);
    void FindNatural(int number, int count = 1)
    {
        if (count % 3 == 0)
            Console.WriteLine(count);
        count++;
        if (count > number)
        {
            return;
        }
        FindNatural(number, count);
    }

}
//Zadacha66();

void Zadacha66()
{
    Console.WriteLine("Введите число N :");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число M :");
    int m = Convert.ToInt32(Console.ReadLine());
    FindSum(n, m);

    void FindSum(int number, int count = 1, int sum = 0)
    {
        sum += count;
        Console.WriteLine(sum);
        count++;
        if (count > number)
        {
            return;

        }
        FindSum(number, count, sum);
    }


}
//Zadacha68();
void Zadacha68()
{
    Console.WriteLine("Введите число m :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n :");
    int n = Convert.ToInt32(Console.ReadLine());
    int functionAkkerman = Ack(m, n);

    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int Ack(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Ack(m - 1, 1);
        else return Ack(m - 1, Ack(m, n - 1));
    }
}