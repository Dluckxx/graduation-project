using UnityEngine;
using Game.Presentation.Area;
using System.Collections.Generic;
using UnityEngine.UI;
using Game.Service;

namespace Game.UI.Components
{
    public class AreaButtonComponent : MonoBehaviour
    {
        public GameObject ButtonPrefab;

        private AreaService mAreaService = ServiceContext.AreaService;

        // Use this for initialization
        void Start()
        {
            List<AreaPoint> areas = mAreaService.GetAreaPoints();
            float i = 0;
            foreach (AreaPoint a in areas)
            {
                GameObject o = Instantiate(ButtonPrefab, transform, false);
                o.GetComponentInChildren<RectTransform>().anchorMin = new Vector2(0.1f, 0.91f - i);
                o.GetComponentInChildren<RectTransform>().anchorMax = new Vector2(0.9f, 0.99f - i);
                o.GetComponentInChildren<Text>().text = a.AreaName;
                o.transform.SetParent(gameObject.transform);

                // Binding click event
                o.GetComponent<Button>().onClick.AddListener(delegate ()
                {
                    OnClickArea(a.AreaName);
                });
               

                i += 0.1f;
            }
        }

        public void OnClickArea(string name)
        {
            GameObject.Find("Player").transform.position = mAreaService.GetAreaTranslateLocation(name);
        }
    }
}