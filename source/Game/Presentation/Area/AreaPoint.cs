using Game.Service;

namespace Game.Presentation.Area
{
    public class AreaPoint
    {
        public string AreaName { get; } // Name
        public bool bIsPlayerInside { get; set; } // Flag means is player in this area

        private readonly AreaService mAreaService = ServiceContext.AreaService;

        public AreaPoint(string areaName)
        {
            AreaName = areaName;
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
