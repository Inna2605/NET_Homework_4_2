//Створити базовий клас «Пристрій» і похідні класи: «Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
//За допомогою конструктора, встановити назву до кожного пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук пристрою (пишемо текстом у консоль);
//■ Show — відображає назву пристрою;
//■ Desc — відображає опис пристрою.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_4_2
{
    internal class Car : Device//автомобіль
    {
        public Car(string name, string descripti) : base(name, descripti) { }

        public override void Sound()
        {
            Console.WriteLine($"{Name} сигнале.");
        }
    }
}
