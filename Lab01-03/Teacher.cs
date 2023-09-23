using Lab01_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Teacher : Person
    {
        private string diaChi;

        public Teacher() { }
        public Teacher(string studentID, string fullName, string diaChi) : base(studentID, fullName)
        {
            this.diaChi = diaChi;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public override void inPut()
        {
            base.inPut();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }
        public override void outPut()
        {
            base.outPut();
            Console.Write($"Dia chi: {this.diaChi}\n");
        }
    }
}
