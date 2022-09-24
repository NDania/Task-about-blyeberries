//Дополнительная задача по сбору черники
Console.Clear();
Console.WriteLine("Введите количество кустов от 3 до 1000: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] a = new int[n];

if (n < 3 || n > 1000)
    Console.WriteLine("Вы ошиблись при вводе и не попали в указанный диапазон. Повторите попытку.");
else
{
    for(int i = 0; i < n; i++)
        a[i] = i+1;
               
 int sum = a[n-1] + a[n-2] + a[n-3];  
 Console.WriteLine("Сумма макс.кол-ва собранных ягод за один заход = " + sum);
}
