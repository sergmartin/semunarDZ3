// Задача №23
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
if (n != 0)
{
    for (int i = 1; i < n; i++) 
    {
        m = n*n*n;
        
    
    }
    Console.Write(m);
}
else Console.Write("ноль использовать нельзя!");