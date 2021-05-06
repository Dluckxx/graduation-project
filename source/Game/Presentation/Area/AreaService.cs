using Game.Service;
using System.Collections.Generic;

namespace Game.Presentation.Area
{
    public class AreaService : ServiceBase
    {
        private List<AreaPoint> mAreaList = new List<AreaPoint>();

        public int Size {
            get {
                return mAreaList.Count;
            }
        }

        public AreaService()
        {
        }

        // Note : return null when player is not in any area
        public AreaPoint GetPlayerCurrentArea()
        {
            foreach (AreaPoint p in mAreaList)
            {
                if (p.bIsPlayerInside == true)
                {
                    return p;
                }
            }
            return null;
        }

        public List<AreaPoint> GetAreaPoints()
        {
            return mAreaList;
        }

        public void AddAreaPoint(AreaPoint area)
        {
            bool flag = false;
            foreach (AreaPoint p in mAreaList)
            {
                if (p.AreaName == area.AreaName)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                mAreaList.Add(area);
            }
        }

        public void RemoveAreaPoint(AreaPoint area)
        {
            foreach(AreaPoint p in mAreaList)
            {
                if (p.AreaName == area.AreaName)
                {
                    mAreaList.Remove(p);
                    break;
                }
            }
        }
    }
}