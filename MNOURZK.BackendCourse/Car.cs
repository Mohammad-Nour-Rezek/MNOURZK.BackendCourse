using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class Car
    {
        public int speed;
        private string color;
        private string brand;

        public void setColor(char color)
        {
            switch (color)
            {
                case 'b':
                    this.color = "black";
                    break;
                case 'w':
                    this.color = "white";
                    break;
                default:
                    break;
            }            
        }

        public string getColor()
        {
            return this.color;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Brand: {this.brand}, Color: {this.color}, Speed: {this.speed}");
        }
    }
}

/* Employee [id, phone, email, name, address, salary] 
 phone lenght 10 digits start with 079,078, 077
salary >= 6000
function increase salary, take amount and increase the salary by that amount
function display info

in main, create an object of employee, and store it as array of employees, Employee[] employees = new Employee[3];
insert related data and print the info of each employee

 */
