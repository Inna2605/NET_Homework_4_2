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
    public class Device//пристрій
    {
        public string Name;
        public string Descripti;

        public Device(string name, string descripti)
        {
            if (name == "")
            {
                throw new ArgumentNullException("Пристроя не існує!");
            }
            Name = name;
            Descripti = descripti;
            
        }

        public virtual void Sound() 
        {
            Console.WriteLine($"{Name} сигнале.");
        }
        public virtual void Show() 
        {
            Console.WriteLine($"Пристрій: {Name}");
        }
        public virtual void Desc() 
        {
            if (Descripti == "")
            {
                throw new ArgumentNullException($"Немає інформації про {Name}!");
            }
            else 
            {
                Console.WriteLine($"Опис: {Descripti}");
            }
        }
    }
}
