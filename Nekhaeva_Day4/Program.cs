using System;

namespace Nekhaeva_Day4
{
    internal class Program
    {
        private static Employee[] Sotrudnik = new Employee[10];

        static void Main(string[] args)
        {
            Sotrudnik[0] = new Employee("Иванов Иван Иванович", 5, 5000);
            Sotrudnik[1] = new Employee("Петров Сергей Константинович", 1, 4350);
            Sotrudnik[2] = new Employee("Лютикова Надежда Петровна", 3, 16700);
            Sotrudnik[3] = new Employee("Герасимова Любовь Павловна", 4, 4200);
            Sotrudnik[4] = new Employee("Юн Алия Ахметовна", 1, 8900);
            Sotrudnik[5] = new Employee("Вьюнков Владислав Владимирович", 2, 15000);
            Sotrudnik[6] = new Employee("Ким Дамира Дмитревна", 3, 27600);
            Sotrudnik[7] = new Employee("Сидоров Илья Иванович", 5, 9850);
            Sotrudnik[8] = new Employee("Крапоткин Виктор Викторович", 4, 10500);
            Sotrudnik[9] = new Employee("Фомина Анна Олеговна", 2, 9250);

            Console.WriteLine("Введите букву задания: ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "a":
            List_of_employees();
                    break;
                case "b":
            Sum_salary();
                    break;
                case "c":
            Min_salary();
                    break;
                case "d":
            Max_salary();
                    break;
                case "e":
            Avg_salary();
                    break;
                case "f":
            Fio_employees();
                    break;
                default: Console.WriteLine("Введите правильное значение.");
                    break;
             }
    }
        static void List_of_employees()
        {
            foreach (Employee a in Sotrudnik)
            {
                if (a != null)
                {
                    Console.WriteLine($"Номер сотрудника: {a.Id}, ФИО: {a.Fio}, Отдел: {a.Department},Зарплата: {a.Salary}");
                }
            }
            Console.ReadLine();
        }
        static void Sum_salary()
        {
            int totalSalary = 0;
            foreach (Employee b in Sotrudnik)
            {
                totalSalary += b.Salary;
            }
            Console.WriteLine($"Сумма затрат на зп в месяц: {totalSalary}");
            Console.WriteLine();
        }
        static void Min_salary()
        {
            int min = Sotrudnik[0].Salary;
            string name = Sotrudnik[0].Fio;
            foreach (Employee c in Sotrudnik)
            {
                if (c.Salary < min)
                {
                    min = c.Salary;
                    name = c.Fio;
                }
            }
            Console.WriteLine($"У сотрудника {name} самая минимальная зп равная {min}.");
            Console.WriteLine();
        }
        static void Max_salary()
        {
            int max = Sotrudnik[0].Salary;
            string name = Sotrudnik[0].Fio;
            foreach (Employee d in Sotrudnik)
            {
                if (d.Salary > max)
                {
                    max = d.Salary;
                    name = d.Fio;
                }
            }
            Console.WriteLine($"У сотрудника {name} самая мaксимальная зп равная {max}.");
            Console.WriteLine();
        }
        static void Avg_salary()
        {
            int sum = 0;
            int chack = 0;
            foreach (Employee e in Sotrudnik)
            {
                sum += e.Salary;
                chack++;
            }
            Console.WriteLine("Средняя запрлата равна: " + (sum / chack));
            Console.WriteLine();
        }
        static void Fio_employees()
        {
            foreach (Employee f in Sotrudnik)
            {
                if (f != null)
                {
                    Console.WriteLine($"ФИО сотрудников: {f.Fio}");
                }
            }
            Console.ReadLine();
        }
    }
}
