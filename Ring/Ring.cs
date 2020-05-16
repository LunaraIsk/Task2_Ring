using System;
using System.Collections.Generic;
using System.Text;

namespace Ring
{
    //Создать класс Ring, описывающий кольцо, заданное координатами центра,
    //внешним и внутренним радиусами, а также свойствами, позволяющими узнать 
    //площадь кольца и суммарную длину внешней и внутренней окружностей.
    class Ring : Point
    {
        internal double Pi = 3.14;
        internal double radius;
        internal double r;
        internal PointPlane point_O;

        public Ring(int x1, int y1, double Radius, double R)
        {
            point_O = new PointPlane(x1, y1);
            radius = Radius;
            r = R;
        }
        public override void Show()
        {
            Console.Write("Координаты центра кольца: ");
            point_O.Show();
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 2)
            {
                point_O.Set(ar[0], ar[1]);
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public PointPlane Point_O
        {
            get
            {
                return point_O;
            }
            set
            {
                point_O = value;

            }
        }
        public double Square_R()//Метод, позволяющий расчитать площадь внешней окружности
        {
            double S_R = Pi * r * r;
            return S_R;
        }
        public double Square_r()//Метод, позволяющий расчитать площадь внутренней окружности
        {
            double S_r = Pi * radius * radius;
            return S_r;
        }
        public double Square_ring()//Метод, позволяющий расчитать площадь кольца
        {
            double S_ring = Square_R() - Square_r();
            return S_ring;
        }
        public double Sum_len()//Метод, позволяющий расчитать суммарную длину внешней и внутренней окружностей
        {
            double Sum_len = 2 * Pi * radius + 2 * Pi * r;
            return Sum_len;
        }
    }
}
