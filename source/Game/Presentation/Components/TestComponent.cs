using Game.Service;
using Game.Presentation.Area;
using UnityEngine;

namespace Game.Presentation.Components
{
    public class TestComponent : MonoBehaviour
    {


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            AreaPoint area = ServiceContext.AreaService.GetPlayerCurrentArea();
            if (area != null)
            {
                Debug.LogFormat("[Presentation][TestComponent] - Current Area : {0}", area.AreaName);
            }
            else
            {
                Debug.Log("[Presentation][TestComponent] - Current Area : NULL");
            }
        }
    }
}