// Напишите программу, используя метод. 
// Если товары стоят больше или равно 1000 рублей, 
//то мы их не покупаем. Стоимость товара задается рандомно
//ответ необходимо предоставить в виде коронарного выражения 

int priceCost = new Random().Next(10000);

Console.WriteLine($"Цена товара: {priceCost}");

// if (priceCost <= 1000)
// {
//     Console.WriteLine("Покупаем");
// }
// else
// {
//     Console.WriteLine("НЕ Покупаем");
// }

bool MaxPrice(int priceCost, int maxPrice)
{
    return priceCost <= maxPrice;
}
Console.WriteLine(MaxPrice(priceCost, 1000) ? "Покупаем" : "НЕ Покупаем");