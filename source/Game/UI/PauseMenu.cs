using Game.Presentation.Area;
using Game.Service;
using UnityEngine;

namespace Game.UI
{
    public class PauseMenu
    {
        public bool bIsShow; // Open or close menu

        public readonly AreaService mAreaService;

        public PauseMenu()
        {
            bIsShow = false;
            mAreaService = ServiceContext.AreaService;
        }

        private void UpdateButtons()
        {
            
        }
    }
}
