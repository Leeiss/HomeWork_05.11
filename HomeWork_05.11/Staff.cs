using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Staff
    {
        internal static Employee ReturnPerson(string name)
        {
            switch (name)
            {
                case "Борис":
                    return Boris;
                case "Рашид":
                    return Rashid;
                case "Ильхам":
                    return Ilham;
                case "Оркадий":
                    return Orkadiy;
                case "Володя":
                    return Volodya;
                case "Ильшат":
                    return Ilshat;
                case "Иваныч":
                    return Ivanich;
                case "Илья":
                    return Ilya;
                case "Витя":
                    return Vitya;
                case "Женя":
                    return Zhenya;
                case "Сергей":
                    return Sergey;
                case "Ляйсан":
                    return Laysan;
                case "Марат":
                    return Marat;
                case "Дина":
                    return Dina;
                case "Ильдар":
                    return Ildar;
                case "Антон":
                    return Anton;
            }
            return new Employee("None");
        }

        internal static Employee Boris = new Employee("Борис",1,"superiors");
        internal static Employee Rashid = new Employee("Рашид",2, "superiors");
        internal static Employee Ilham = new Employee("Ильхам",2, "superiors");
        internal static Employee Orkadiy = new Employee("Аркадий", 3, "superiors");
        internal static Employee Volodya = new Employee("Володя", 3, "superiors");
        internal static Employee Ilshat = new Employee("Ильшат", 4, "system");
        internal static Employee Ivanich = new Employee("Иваныч", 5, "system");
        internal static Employee Ilya = new Employee("Илья", 6, "system");
        internal static Employee Vitya = new Employee("Витя", 6, "system");
        internal static Employee Zhenya = new Employee("Женя", 6, "system");
        internal static Employee Sergey = new Employee("Сергей", 5, "development");
        internal static Employee Laysan = new Employee("Ляйсан", 5, "development");
        internal static Employee Marat = new Employee("Марат", 6, "development");
        internal static Employee Dina = new Employee("Дина", 6, "development");
        internal static Employee Ildar = new Employee("Ильдар", 6, "development");
        internal static Employee Anton = new Employee("Антон", 6, "development");
    }
}9