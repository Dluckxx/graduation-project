using Game.Service;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Presentation.Area
{
    public class AreaService : ServiceBase
    {
        private List<AreaPoint> mAreaList = new List<AreaPoint>();



        public int Size { get; }
        public float TranslateHeight { get; set; }

        public AreaService()
        {
            Size = mAreaList.Count;
        }

        public override void Setup()
        {
            TranslateHeight = 4.0f;
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

        public AreaPoint GetAreaPointByName(string name)
        {
            foreach (AreaPoint p in mAreaList)
            {
                if (p.AreaName == name)
                {
                    return p;
                }
            }
            return null;
        }

        public Vector3 GetAreaTranslateLocation(string name)
        {
            AreaPoint area = GetAreaPointByName(name);
            if (area != null)
            {
                Vector3 ret = area.Location;
                ret.y += TranslateHeight;
                return ret;
            }

            return new Vector3();
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