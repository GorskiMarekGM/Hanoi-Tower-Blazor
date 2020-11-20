using System;
using System.Collections.Generic;

namespace hanoi.Data
{
    public class HanoiTower: HanoiGame
    {
        private bool selected {get;set;}
        private int currentDiskCounter = 0;
        public List<HanoiDisk> disks = new List<HanoiDisk>();

        public HanoiTower()
        {
            
        }
        public bool pushDisk(HanoiDisk d)
        {
            currentDiskCounter++;
            disks.Add(d);
        }
        public HanoiDisk popDisk()
        {
            HanoiDisk popThis = disks[disks.Count-1];

            disks.RemoveAt(disks.Count-1);
            currentDiskCounter--;

            return popThis;
        }
        public void startDiskCounter()
        {
            Console.WriteLine("Tower: "+{HanoiGame.getTower()} + {currentDiskCounter}" disks");
        }
        public HanoiDisk getNextDisk()
        {

        }
        public bool is_selected()
        {
            return selected;
        }
        public void selection(bool trueForSelected)
        {

        }

    }
}