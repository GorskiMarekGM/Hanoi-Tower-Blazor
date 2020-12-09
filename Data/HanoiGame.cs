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
        
        public HanoiTower addTower(HanoiTower tower)
        {
            towers.Add(tower);

            return tower;
        }

        public HanoiTower getTower(int towerId)
        {
            return towers[towerId];
        }
        
        public void toConsole()
        {
            for(int i=0; i<towers.Count; i++)
            {
                getTower(i).startDiskCounter(i);
            }
            
        }
        public int totalOfTowers()
        {
            return towers.Count;
        }

    }
}