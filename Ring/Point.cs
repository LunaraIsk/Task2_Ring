using System;
using System.Collections.Generic;
using System.Text;

namespace Ring
{
    abstract public class Point
    {
        abstract public void Show(); //выводит объект на экран
        abstract public void Set(params int[] ar);//устанавливает поля объекта

    }
}
