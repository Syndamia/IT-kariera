using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BONUS_NMSequence {
    class Program {
        static void Main(string[] args) {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input[0], m = input[1];
            var numbers = new Queue<int>();

            if (m > n) { //виж най-отдолу как работи
                var element = n;
                for (int i = 0; !numbers.Any(x => x == m); i++) {
                    numbers.Enqueue(element + 1);
                    numbers.Enqueue(element + 2);
                    numbers.Enqueue(element * 2);

                    element = numbers.ElementAt(i);
                }

                var shortestSeq = new Stack<int>();
                for (int i = Array.IndexOf(numbers.ToArray(), m); i > -1; i = (i / 3) - 1) {
                    shortestSeq.Push(numbers.ElementAt(i));
                }
                shortestSeq.Push(n);

                Console.WriteLine(string.Join(" -> ", shortestSeq));
            }
            else Console.WriteLine("(няма решение)");

            /*
             * Идеята на алгоритъма е че добавя тройка числа за всяко число в опашка (виж отдолу за пример, как действа) до първото срещане на желаното число, след това отиваме от пред на зад, от нашето число издирваме 
             * числото което го съставя, после на него, това което него го създава, и така докато стигнем до началото (намираме индекса на предишното число като разделяме този на сегашното с 3 (понеже работим с тройки
             * числа) и от него вадим 1, понеже индексите ни се броят от 0). Най-накрая добавяме първоначалното число n в опашката и сме готови (изпозлвах Stack защото 1) да го упражня и 2) то е от тип "Last in, first out" 
             * и имайки се предвид че аз изкарвам числата в обратен ред, от последното до първото, не е нужно да правя .Reverse)
             * 
             * "Визуализация" на как работи (при n = 3 и m = 10):
             * 
             * 3+1 3+2 3*2 4+1 4+2 4*2 5+1 5+2 5*2  Как се образува всяко число (започваме с n и после се движим по опашката)
             *  4   5   6 | 5   6   8 | 6   7   10  Числата в опашката (използвам | за да разгранича визуални всяка тройка)
             *  0   1   2   3   4   5   6   7   8   Индекси на всяко число
             *  
             * Започваме от 10, нейния индекс е 8, 8 / 3 = 2 (int закръгля надолу) - 1 = 1, тоест числото от първи индекс, 5, е създало 10, след това 1 / 3 = 0 - 1 = -1, това е по-малко от 0, и затова излизаме от цикъла
             */
        }
    }
}
