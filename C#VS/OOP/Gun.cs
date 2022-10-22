using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Gun
    {
        /* СПЕЦИАЛЬНЫЙ СНИППЕТ (написать ctor и давжды на tap) */
        public Gun(bool isLoaded) // Конструктор такой же компонент класса, как и методы!
        {
            this.isLoaded = isLoaded; //this полезная темая для помощи компилятора определить переменные с одинаковыми названиями
        }



        private bool isLoaded = false;
        private void Reload()
        {
            Console.WriteLine("Reloading...");
            isLoaded = true;
            Console.WriteLine("Reloaded!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("The gun is empty!");
                Reload();
                Shoot();
            }
            else
            {
                Console.WriteLine("Fire!");
                isLoaded = false;
            }    
        }
    }
}
