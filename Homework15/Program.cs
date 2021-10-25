using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int difference;
        int x;
        int secondNumber;
        public void SetStart(int x) // устанавливает начальное значение
        {
            Convert.ToInt32(Console.ReadLine());
        }
        public int GetNext() //возвращает следующее число ряда
        {
            secondNumber = x + difference;
            return secondNumber;
        }
        public void Reset() //выполняет сброс к начальному значению
        {
            int firstNumber = secondNumber - difference;
        }
    }

    class GeomProgression : ISeries
    {
        int difference;
        int x;
        int secondNumber;
        public void SetStart(int x) // устанавливает начальное значение
        {
            Console.ReadLine();
        }
        public int GetNext() //возвращает следующее число ряда
        {
            return x * difference;
        }
        public void Reset() //выполняет сброс к начальному значению
        {
            int firstNumber = secondNumber / difference;
        }

    }
}

