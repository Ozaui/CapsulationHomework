using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsulationHomework
{
    internal class Employee
    {
        private string employeeTCNo;
        private bool control = false;

        public string EMPLOYEETCNO
        {
            get 
            {
                return employeeTCNo;
            }
            set
            {
                if (value.Length == 11)
                {   
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool isNumber = char.IsNumber(value[i]);
                        if (isNumber)
                        {
                            employeeTCNo = value;
                        }
                        else
                        {
                            control = false;
                            break;
                        }
                    }
                    if(control)
                    {
                        Console.WriteLine("The character you entered is incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("the value you entered is incorrect");
                }
            }
        }
    }
}
