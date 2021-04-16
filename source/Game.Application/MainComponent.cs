using UnityEngine;

namespace Game.Application{
    public class MainComponent : MonoBehaviour
    {
        private const int mMapCapecity = 7;  // Maps number size

        public GameObject mMainMap = null;  // Main map ref
        public GameObject[] mMap = new GameObject[mMapCapecity];  // Map store array

        // Main component drives Main class
        Main mMain;

        public MainComponent()
        {
            mMain = new Main();
        }

        private void Awake()
        {
            mMain.Setup();

            Debug.Log("[Application] [MainComponent] - Starting game ...");

            Instantiate(mMainMap);
        }

        private void Update()
        {
            mMain.Tick();
        }
    }
}