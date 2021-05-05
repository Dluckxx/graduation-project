using Game.Service;
using Game.Presentation.Area;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Presentation.Components
{
    public class HUDAreaComponent : MonoBehaviour
    {
        private Text mText;

        // Use this for initialization
        void Start()
        {
            mText = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdataAreaText();
        }

        // Get current area and update UI text
        private void UpdataAreaText()
        {
            AreaPoint area = ServiceContext.AreaService.GetPlayerCurrentArea();
            if (area != null)
            {
                mText.text = area.AreaName;
            }
            else
            {
                mText.text = "当前不处于任何区域";
            }
        }
    }
}