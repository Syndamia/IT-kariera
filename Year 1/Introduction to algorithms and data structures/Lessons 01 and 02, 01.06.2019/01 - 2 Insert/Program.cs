using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___2_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Максимален брой стъпки (сложност) е: 6n + 11 (n е броя въведени числа)

            List<int> numbers = Console.ReadLine()  // +1 стъпка (за четене от конзолата)
                                .Split(' ')         // +n стъпка (за всяко изважадане на елемент)
                                .Select(int.Parse)  // +n стъпка (за промяна на типа данни на всеки елемент)
                                .ToList();          // +1 стъпка (за "превръщане" на елементите в лист)

            int toInsert = int.Parse(Console.ReadLine()); // +2 стъпки (1 за четене от конзолата и още 1 за превръщане на типа данни)

            Console.WriteLine(string.Join(" ", numbers)); //+2 стъпки (1 за да съедини елементите в един string и 1 за да изпише string на екрана) 

            for (int i = 0; i < numbers.Count; i++) //в най-лошия случай, ще превъртим през целия лист, тоест: 1 (създаване на i) + 2n (добавяне на 1 към i и правене на сравнение) - 1 (при първо завъртане на цикъла не добавяме 1 към i) или просто 2n (само за този ред)
            {
                if (numbers[i] > toInsert) //+2 стъпки (към цикъла за 1 завъртане) (1 стъпка за да извади елемента от дадената позиция и още 1 за да сравни)
                { numbers.Insert(i, toInsert); break; } //+2 стъпки (за най-лошия случай това не ни интересува) (1 за да вмъкне числото и още 1 за break)
            }//общо, в най-лошия случай, цикъла ще е 4n (2 * 2n, защото за всяко завъртане добавяме 2 стъпки, и щом 2n показва общо завъртанията просто ги умножаваме)

            if (!numbers.Contains(toInsert)) //+2 стъпки (1 за да намерим дали го има и още 1 за да провери дали може да влезе)
                numbers.Add(toInsert); //+1 стъпка

            Console.WriteLine(string.Join(" ", numbers)); //+2 стъпки (1 за да съедини елементите в един string и 1 за да изпише string на екрана) 
        }
    }
}
