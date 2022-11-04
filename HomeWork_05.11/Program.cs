using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Борис { }
    class Рашид : Борис { } 
    class Лукас : Рашид { }
    class Buh : Лукас { }
    class ОИльхам : Борис { } 
    class Оркадий : ОИльхам { }
    class Володя : Оркадий { }
    class Ильшат : Володя { } 
    class Иваныч : Ильшат { }
    class Илья : Иваныч { }
    class Витя : Иваныч { }
    class Женя : Иваныч { }
    class Сергей : Володя { }
    class Ляйсан : Сергей { }
    class Марат : Ляйсан { }
    class Дина : Ляйсан { }
    class Ильдар : Ляйсан { }
    class Антон : Ляйсан { }
    class Program
    {
        static void Otvet(Type a, Type b, string name)
        {
            if (a.IsSubclassOf(b)) 
            { 
                Console.WriteLine($"{name} принимает задачу"); 
            }
            else
            {
                Console.WriteLine($"{name} не принимает задачу");
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите имя человека, который дает задачу: ");
            string guarantor = Console.ReadLine();
            Console.Write("Введите имя человека, которому дают задачу: ");
            string performer = Console.ReadLine();
            Console.Write("Введите задачу: ");
            string C1 = Console.ReadLine();
            Type A = Type.GetType("HomeWork" + "." + guarantor, false, true); 
            Type B = Type.GetType("HomeWork" + "." + performer, false, true);
            Console.WriteLine($"От рабонитка {guarantor} дана задача {C1}  для работника {performer}.");
            Otvet(B, A, performer);
        }
    }
}

