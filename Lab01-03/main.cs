using Lab01_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    internal class main
    {
        public static void Main(string[] args)
        {
            List<Person> listPerson = nhapPerson();
            bool menu = false;
            do
            {
                Console.WriteLine("\n\n--------------------MENU------------------");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them giao vien");
                Console.WriteLine("3. Xuat danh sach sinh vien");
                Console.WriteLine("4. Xuat danh sach giao vien");
                Console.WriteLine("5. Xuat so luong tung danh sach");
                Console.WriteLine("6. Xuat danh sach cac sinh vien thuoc khoa CNTT");
                Console.WriteLine("7. Xuat ra danh sach giao vien co dia chi chua thong tin Q9");
                Console.WriteLine("8. Xuat ra danh sach SV co DTB cao nhat va thuoc khoa CNTT");
                Console.WriteLine("9. Cho biet so luong cua tung xep loai trong danh sach");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("--------------------------------------------\n");

                Console.WriteLine("Chon chuc nang: "); var chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            addPerson(listPerson, "sv");
                            break;
                        }
                    case 2:
                        {
                            addPerson(listPerson, "gv");
                            break;
                        }
                    case 3:
                        {
                            xuatDSSV(listPerson);
                            break;
                        }
                    case 4:
                        {
                            xuatDSGV(listPerson);
                            break;
                        }
                    case 5:
                        {
                            xuatSLDS(listPerson);
                            break;
                        }
                    case 6:
                        {
                            XuatDSSV_CNTT(listPerson);
                            break;
                        }
                    case 7:
                        {
                            xuatDSGV_Q9(listPerson);
                            break;
                        }
                    case 8:
                        {
                            XuatDSSV_MAXDTB_CNTT(listPerson);
                            break;
                        }
                    case 9:
                        {
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Thoat chuong trinh");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Chuc nang khong co trong menu");
                            break;
                        }
                }

            } while (!menu);
        }

        private static List<Person> nhapPerson()
        {
            List<Person> listPerson = new List<Person>();
            listPerson.Add(new Student("21A", "Hoang", 8.9f, "CNTT"));
            listPerson.Add(new Student("21B", "Nhu", 6.9f, "CNTT"));
            listPerson.Add(new Student("21C", "Yen", 7.9f, "CNTP"));
            listPerson.Add(new Student("21D", "Hau", 4.9f, "CNTT"));
            listPerson.Add(new Teacher("19A", "Nga", "Quan 9"));
            listPerson.Add(new Teacher("19B", "Huyen", "Quan 8"));
            listPerson.Add(new Teacher("19C", "Gia", "Quan 6"));
            listPerson.Add(new Teacher("19D", "Nam", "Quan 9"));
            return listPerson;
        }

        private static void addPerson(List<Person> listPerson, string nguoi)
        {
            if (nguoi == "sv")
            {
                Console.WriteLine("Nhap so luong sinh vien muon them: ");
                var n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Person person = new Student();
                    person.inPut();
                    listPerson.Add(person);
                }
            }
            else if (nguoi == "gv")
            {
                Console.WriteLine("Nhap so luong giao vien muon them: ");
                var n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Person person = new Teacher();
                    person.inPut();
                    listPerson.Add(person);
                }

            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        //Xuat DS all
        private static void xuatDS(List<Person> listPerson)
        {
            foreach (Person person in listPerson)
            {
                person.outPut();
            }
        }

        //Xuat DS SV
        private static void xuatDSSV(List<Person> listPerson)
        {
            foreach (Person person in listPerson)
            {
                if (person is Student)
                {
                    person.outPut();
                }
            }
        }

        //Xuat DS GV
        private static void xuatDSGV(List<Person> listPerson)
        {
            foreach (Person person in listPerson)
            {
                if (person is Teacher)
                {
                    person.outPut();
                }
            }
        }

        //Xuat so luong tung danh sach
        private static void xuatSLDS(List<Person> listPerson)
        {
            var countSV = listPerson.OfType<Student>().Count();
            var countGV = listPerson.OfType<Teacher>().Count();

            Console.WriteLine($"Tong so sinh vien trong DS la: {countSV}");
            Console.WriteLine($"Tong so giao vien trong DS la: {countGV}");
        }

        //Xuat DS cac SV thuoc khoa CNTT
        private static void XuatDSSV_CNTT(List<Person> listPerson)
        {
            var result = listPerson.OfType<Student>().Where(p => p.Faculty == "CNTT").ToList();
            foreach (Person person in result)
            {
                person.outPut();
            }
        }

        //Xuat ra danh sach giao vien co dia chi chua thong tin Q9  
        private static void xuatDSGV_Q9(List<Person> listPerson)
        {
            var result = listPerson.OfType<Teacher>().Where(p => p.DiaChi.ToLower() == "Quan9"); //thuoc tinh ToLower cho phep chữ hoa và thường
            foreach (Person person in result)
            {
                person.outPut();
            }

        }

        //Xuat ra danh sach SV co DTB cao nhat va thuoc khoa CNTT
        private static void XuatDSSV_MAXDTB_CNTT(List<Person> listPerson)
        {
            var maxDTB = listPerson.OfType<Student>().Max(p => p.AverageScore);
            var result = listPerson.OfType<Student>().Where(p => (p.Faculty == "CNTT") &&  (p.AverageScore == maxDTB));
            foreach (Person person in result)
            {
                person.outPut();
            }
        }
    }
}

