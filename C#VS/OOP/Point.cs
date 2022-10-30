﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Point
    {
        //private int x;
        //public int y;

        ////СВОЙСТВА get set | ключевое слово value                                     СВОЙСТВА get set | ключевое слово value  

        // сниппет propfull (два раза tap)
        //private int y;

        //public int Y
        //{
        //    /*аксессоры get & set*/
        //    get { return y; }
        //    set { y = value;/*ключевое слово, подстраивается под тип данных как в методе*/ }
        //}

        //private int x;

        //public int X
        //{
        //    get { return x; } // Можно в аксессоры даже режим доступа поставить (public || private)
        //    set {
        //        if (value < 1)
        //        {
        //            x = 1;
        //            return;
        //        }
        //        else if (value > 5)
        //        {
        //            x = 5;
        //            return;
        //        }
        //        x = value;
        //    }
        //}

        //// Иной сниппет prop - автоматическое свойство
        //public int MyProperty { get; set; } // Просто тут неявно описано то, что есть в propfull


    }

    internal class MyClass
    {
        ////СТАТИЧЕСКИЙ МЕТОД                                                           СТАТИЧЕСКИЙ МЕТОД 
        //public MyClass()
        //{
        //    counter++;
        //}
        //private static int counter;

        //public static int Counter
        //{
        //    get { return counter; }
        //    private set { counter = value; } // private нужен для инкапсуляцци,
        //    // чтобы мы могли юзать сеттер внутри класса, но не могли повлиять в главном файле
        //}

        //public int a;
        //public static int b; // статичное поле
        //public static void Foo()
        //{
        //    // тут мы не можем работать с не-static членами
        //    // Из-за static мы теряем возможность использовать полиморфизм для ООП (т.к. необходимо создавать экземпляр)
        //}
        //public void Boo()
        //{
        //    // Тут мы можем юзать и static и non-static члены
        //}
    }

    //// СТАТИЧЕСКИЙ КЛАСС                                                              СТАТИЧЕСКИЙ КЛАСС
    //static internal class StaticClass
    //{
    //    // Можно ток всё в static
    //}
}