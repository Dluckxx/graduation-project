using Game.Service;
using UnityEngine;

namespace Game.Presentation.Area
{
    public class AreaPoint
    {
        public string AreaName { get; } // Name
        public Vector3 Location { get; } // Name
        public bool bIsPlayerInside { get; set; } // Flag means is player in this area

        private readonly AreaService mAreaService = ServiceContext.AreaService;

        public AreaPoint(string areaName, Vector3 location)
        {
            AreaName = areaName;
            Location = location;
            bIsPlayerInside = false;
        }

        public void Register()
        {
            mAreaService.AddAreaPoint(this);
        }

        public void UnRegister()
        {
            mAreaService.RemoveAreaPoint(this);
        }
    }
}
