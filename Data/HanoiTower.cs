using System;
using System.Collections.Generic;

namespace hanoi.Data
{
    public class HanoiTower: HanoiGame
    {
        private HanoiGame game;
        private bool selected {get;set;}
        private int currentDiskCounter = 0;
        public List<HanoiDisk> disks = new List<HanoiDisk>();

        public HanoiTower(HanoiGame gameHanoi)
        {
            this.game = gameHanoi;
        }
        public bool pushDisk(HanoiDisk d)
        {
            currentDiskCounter++;
            disks.Add(d);

            return true;
        }
        public HanoiDisk popDisk()
        {
            HanoiDisk popThis = disks[disks.Count-1];

            disks.RemoveAt(disks.Count-1);
            currentDiskCounter--;

            return popThis;
        }
        public HanoiDisk getDisk(int diskId)
        {
            return disks[diskId];
        }
        public void startDiskCounter(int id)
        {
            Console.WriteLine("Tower: {0} - {1} disks",id,currentDiskCounter);

            for(int i=0; i<disks.Count; i++)
            {
                getDisk(i).displayDisk(i);
            }
        }
        public HanoiDisk getNextDisk()
        {
            if(disks.Count>0)
            {
                var item = disks[disks.Count - 1];
                return item;
            }
            return null;
        }
        public bool is_selected()
        {
            return selected;
        }
        public void selection(bool trueForSelected)
        {
            selected = trueForSelected;
        }

    }
}