using Game.Service;
using System.Collections.Generic;

namespace Game.Presentation.Area
{
    public class AreaService : ServiceBase
    {
        private List<AreaPoint> AreaList = new List<AreaPoint>();

        public AreaService()
        {
        }

        // Note : return null when player is not in any area
        public AreaPoint GetPlayerCurrentArea()
        {
            foreach (AreaPoint p in AreaList)
            {
                if (p.bIsPlayerInside == true)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddAreaPoint(AreaPoint area)
        {
            bool flag = false;
            foreach (AreaPoint p in AreaList)
            {
                if (p.AreaName == area.AreaName)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                AreaList.Add(area);
            }
        }

        public void RemoveAreaPoint(AreaPoint area)
        {
            foreach(AreaPoint p in AreaList)
            {
                if (p.AreaName == area.AreaName)
                {
                    AreaList.Remove(p);
                    break;
                }
            }
        }
    }
}