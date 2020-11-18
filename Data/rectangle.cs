using System;

namespace hanoi.Data
{
    public class Rectangle
    {
        public int id {get;set;}
        public string color {get;set;}

        public Rectangle(int idr, string colorr)
        {
            this.id = idr;
            this.color = colorr;
        }

    }
}