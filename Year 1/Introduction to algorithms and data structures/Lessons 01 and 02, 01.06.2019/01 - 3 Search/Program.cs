using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___3_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимален брой стъпки (сложност) е: 16n - 7 (n е броя въведени числа)

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
                else if (i == numbers.Count - 1 || numbers[i] > checkNum) //+5 стъпки (1 за изваждане на 1 от numbers.Count, 1 за сравнение (дали е равно), 1 за изваждане на число от numbers, 1 за сравнение с checkNum и накрая 1 за сравнение между двете сравнения)
                { Console.WriteLine($"{checkNum} Not exists in the List"); break; } //+3 стъпки (1 за слагане на checkNum в string, 1 за да изпишем на екрана и 1 за break)
            }// общо за цикъла имаме 14n - 11 (умножаваме 2n - 2 с 7, понеже в най-лошия случай за всяко завъртане ще имаме 7 действия и накрая обавяме 3, за онова финално изписване на екрана)
        }
    }
}
