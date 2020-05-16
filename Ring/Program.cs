using System;
using System.IO;
namespace Ring
{
    class Program
    {
        static public Point[] Input() //читаем данные из файла
        {
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                int n = int.Parse(fileIn.ReadLine());
                Point[] ar = new Point[n];
                for (int i = 0; i < n; i++)
                {
                    string[] text = fileIn.ReadLine().Split(' ');
                    if (text.Length == 2)
                    {
                        ar[i] = new PointPlane(int.Parse(text[0]), int.Parse(text[1]));
                    }
                    else
                    {
                        if (text.Length == 4)
                        {
                            ar[i] = new Ring(int.Parse(text[0]), int.Parse(text[1]), double.Parse(text[2]), double.Parse(text[3]));
                        }

                        else
                        {
                            Console.WriteLine("Неверное количество аргументов");
                        }
                    }
                }
                return ar;
            }
        }
        static void Print(Point[] array) //выводим данные 
        {
            using (StreamWriter fileout = new StreamWriter("output.txt"))
            {
                foreach (Ring temp in array)
                {
                    temp.Show();
                    fileout.WriteLine("Площадь внешней окружности: {0:f2}", temp.Square_R());
                    fileout.WriteLine("Площадь внутренней окружности: {0:f2}", temp.Square_r());
                    fileout.WriteLine("Площадь кольца: {0:f2}", temp.Square_ring());
                    fileout.WriteLine("Суммарная длина внешней и внутренней окружностей: {0:f2}", temp.Sum_len());

                }
            }
        }
        static void Main(string[] args)
        {
            Point[] array = Input();
            Print(array);
            Console.ReadKey();
        }
    }
}
