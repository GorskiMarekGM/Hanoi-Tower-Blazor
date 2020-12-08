using System;

namespace hanoi.Data
{
    public class HanoiDisk
    {
        private int size {get;set;}
        private string color {get;set;}

        public HanoiDisk(int sizex, string colorx)
        {
            this.size = sizex;
            this.color = colorx;
        }

    }
}