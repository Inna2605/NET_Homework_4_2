//Створити базовий клас «Пристрій» і похідні класи: «Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
//За допомогою конструктора, встановити назву до кожного пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук пристрою (пишемо текстом у консоль);
//■ Show — відображає назву пристрою;
//■ Desc — відображає опис пристрою.

using NET_Homework_4_2;
using System;
using System.Security.Cryptography;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int a = 1;

while(a != 0)
{
    Console.WriteLine("\nОберіть пристрій:\n" +
        "0. Закінчення роботи;\n" +
        "1. Чайник;\n" +
        "2. Мікрохвильовка;\n" +
        "3. Автомобіль;\n" +
        "4. Пароплав.\n");
    
        a = Convert.ToByte(Console.ReadLine());
   
    switch (a)
    {
            case 0: { break; }
            case 1: 
            {
                try 
                {
                    Kettle kettle = new Kettle("Чайник", "Опис чайника");
                    kettle.Show();
                    kettle.Sound();
                    kettle.Desc();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                break;
            }
            case 2:
            {
                try
                {
                    Microwave microwave = new Microwave("Мікрохвильовка", "Опис мікрохвильовки");
                    microwave.Show();
                    microwave.Sound();
                    microwave.Desc();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            }
            case 3:
            {
                try
                {
                    Car car = new Car("Автомобіль", "Опис автомобіля");
                    car.Show();
                    car.Sound();
                    car.Desc();
            }
                catch(Exception ex)
                {
                Console.WriteLine(ex.Message);
            }
            break;
            }
            case 4:
            {
                try
                {
                    Steamer steamer = new Steamer("Пароплав", "Опис пароплава");
                    steamer.Show();
                    steamer.Sound();
                    steamer.Desc();
        }
                catch(Exception ex)
                {
            Console.WriteLine(ex.Message);
        }
        break;
            }
    }
}

