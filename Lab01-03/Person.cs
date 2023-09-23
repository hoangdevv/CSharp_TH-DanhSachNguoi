using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Person
    {
        private string studentID;
        private string fullName;

        public Person() { }

        public Person(string studentID, string fullName)
        {
            this.studentID = studentID;
            this.fullName = fullName;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public virtual void inPut()
        {
            Console.WriteLine("Nhap MSSV: ");
            studentID = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien: ");
            fullName = Console.ReadLine();
        }

        public virtual void outPut()
        {
            Console.Write($"MSSV: {this.studentID} | Hoten: {this.fullName} |");
        }
    }
}
