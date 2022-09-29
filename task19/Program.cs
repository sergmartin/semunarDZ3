// задача 19

int n = 0;
while (n < 10000 || n > 99999)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

string m = Convert.ToString(n);
 
 if (m[0] == m[4] && m[1] == m[3]) Console.Write($" {n} полиндром!");
 else Console.Write($" {n} не полиндром!");
 