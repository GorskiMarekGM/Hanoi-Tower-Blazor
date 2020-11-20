using System;
using System.Collections.Generic;
using System.Linq;

namespace hanoi.Data
{
    public class HanoiGame
    {
        private int svgHeight {get;set;}
        private int svhWidth {get;set;}
        
        public List<HanoiTower> towers = new List<HanoiTower>();

        public HanoiGame()
        {
            
        }
        
        public HanoiTower addTower()
        {
            HanoiTower t1 = new HanoiTower();
            towers.Add(t1);

            return t1;
        }

        public HanoiTower getTower(int towerId)
        {
            return towers[towerId];
        }
        
        public void toConsole()
        {
            Console.WriteLine("Tower: {0} - {1} disks",totalOfTowers(),2);
        }
        public int totalOfTowers()
        {
            return towers.Count;
        }

    }
}