using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekhaeva_Day4
{
    public class Employee
    {
        private string _fio;
        private int _department;
        private int _salary;
        private static int _counter = 0;
        private int _id;

        public Employee(string fio, int department, int salary)
        {
            _fio = fio;
            _department = department;
            _salary = salary;

           _id = ++_counter;
        }
        public string Fio
        {
            get => _fio;
        }
        public int Department
        { 
            get => _department;
            set => _department = value; 
        }
        public int Salary 
        { 
            get => _salary;
            set => _salary = value;
        }
        public int Id 
        { 
            get => _id;
        }
    }
}
