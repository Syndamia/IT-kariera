using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___1_BelongN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимален брой стъпки (сложност) е: 10n - 1 (n е броя въведени числа)

            List<int> numbers = Console.ReadLine()  // +1 стъпка (за четене от конзолата)
                                .Split(' ')         // +n стъпка (за всяко изважадане на елемент)
                                .Select(int.Parse)  // +n стъпка (за промяна на типа данни на всеки елемент)
                                .ToList();          // +1 стъпка (за "превръщане" на елементите в лист)

            int checkNum = int.Parse(Console.ReadLine()); // +2 стъпки (1 за четене от конзолата и още 1 за превръщане на типа данни)

            //нарочно не използвам .Contains() метода защото не знаем какви и колко действия се извършват в него
            for (int i = 0; i < numbers.Count; i++) //в най-лошия случай ще минем през целия лист: 1 (за създаване на i) + 2n (добавяне на 1 към i и правене на сравнение) - 3 (при първо завъртане само сравняваме i, заради break най-накрая няма да добавим един оследен път 1 към i и да сравним) или 2n - 2
            {
                if (numbers[i] == checkNum) //+2 стъпки (1 за извикване на числото и още 1 за сравнение)
                { Console.WriteLine($"{checkNum} Exists in the List"); break; } //+3 стъпки (не ни интересува когато гледаме макс брой стъпки) (1 за слагане на checkNum в string, 1 за да изпишем на екрана и 1 за break)
                else if (i == numbers.Count - 1) //+2 стъпки (1 за изваждане на 1 от numbers.Count и 1 за сравнение)
                { Console.WriteLine($"{checkNum} Not exists in the List"); break; } //+3 стъпки (1 за слагане на checkNum в string, 1 за да изпишем на екрана и 1 за break)
            }// общо за цикъла имаме 8n - 5 стъпки (умножаваме 2n - 2 с 4, понеже в най-лошия случай за всяко завъртане ще имаме 4 действия и накрая обавяме 3, за онова финално изписване на екрана)
        }
    }
}
