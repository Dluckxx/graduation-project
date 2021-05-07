using Game.Presentation.Area;
using UnityEngine;

namespace Game.Presentation.Components
{
    public class AreaPointComponent : MonoBehaviour
    {
        public string Name;

        private AreaPoint mAreaPoint;

        void Awake()
        {
            mAreaPoint = new AreaPoint(Name, transform.position);
        }

        // Use this for initialization
        void Start()
        {
            mAreaPoint.Register();
        }

        void OnDestroy()
        {
            mAreaPoint.UnRegister();
        }

        void OnTriggerEnter(Collider coll)
        {
            if (coll.tag == "Player")
            {
                mAreaPoint.bIsPlayerInside = true;
            }
        }

        void OnTriggerStay(Collider coll)
        {
            if (coll.tag == "Player")
            {
                mAreaPoint.bIsPlayerInside = true;
            }
        }

        void OnTriggerExit(Collider coll)
        {
            if (coll.tag == "Player")
            {
                mAreaPoint.bIsPlayerInside = false;
            }
        }
    }
}