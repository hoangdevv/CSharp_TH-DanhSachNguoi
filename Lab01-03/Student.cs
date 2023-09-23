using Lab01_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class Student : Person
    {
        private float averageScore;
        private string faculty;

        public Student() { }
        public Student(string studentID, string fullName, float averageScore, string faculty) : base(studentID, fullName)
        {
            this.AverageScore = averageScore;
            this.Faculty = faculty;
        }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public override void inPut()
        {
            base.inPut();
            float result;
            bool averagel;
            do
            {
                Console.WriteLine("Nhap diem trung binh");
                string text = Console.ReadLine();
                averagel = float.TryParse(text, out result);
                if (!averagel)
                {
                    Console.WriteLine("Nhap sai! Nhap lai diem trung binh");
                }
            } while (!averagel);
            averageScore = result;

            Console.WriteLine("Nhap khoa: ");
            faculty = Console.ReadLine();
        }

        public override void outPut()
        {
            base.outPut();
            Console.Write($"DTB: {this.averageScore} | Khoa: {this.faculty}\n");
        }
    }
}
