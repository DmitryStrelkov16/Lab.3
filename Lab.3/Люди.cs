using System;
using System.Collections.Generic;
using System.Text;

namespace Lab._3
{
    abstract class Люди
    {
        string Имя;
        int Возраст;
        public abstract void Музыкальные_пристрастия();

        public void getИмя()
        {
            Console.WriteLine(Имя);
            Console.ReadLine();
        }


    }
}
