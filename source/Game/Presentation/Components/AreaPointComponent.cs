using Game.Presentation.Area;
using UnityEngine;

namespace Game.Presentation.Components
{
    public class AreaPointComponent : MonoBehaviour
    {
        public string Name;

        private AreaPoint mAreaPoint;

        private Vector3 mSize;
        private BoxCollider mBoxCollider;

        void Awake()
        {
            mBoxCollider = GetComponent<BoxCollider>();
            mSize = mBoxCollider.size;

            mAreaPoint = new AreaPoint(Name);
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