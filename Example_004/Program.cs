Console.WriteLine("Введите день недели числом");
int number = int.Parse(Console.ReadLine());

if(number <= 7 && number >= 1)
{
    if (number == 1)
    {
        Console.WriteLine("Вы ввели Понедельник");
    }
    else
    {
        if (number == 2)
        {
            Console.WriteLine("Вы ввели Вторник");
        }
        else
        {
           if (number == 3) 
           {
            Console.WriteLine("Вы ввели Среду");
           }
           else
           {
            if (number == 4)
            {
                Console.WriteLine("Вы ввели Четверг");
            }
            else 
            {
               if (number == 5)
               {
                Console.WriteLine("Вы ввели Пятницу");
               } 
               else
               {
                if (number == 6)
                {
                 Console.WriteLine("Вы ввели Субботу");
                }
                else
                {
                Console.WriteLine("Вы ввели Воскресенье");
                }
               }
            }
           }
        }
    }
}
else
{
    Console.WriteLine("Нет такого дня недели");
}