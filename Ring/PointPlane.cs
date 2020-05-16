using System;
using System.Collections.Generic;
using System.Text;

namespace Ring
{
    class PointPlane : Point
    {
        protected int x;
        protected int y;
        public PointPlane(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override void Show()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 2)
            {
                this.x = ar[0];
                this.y = ar[1];
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
