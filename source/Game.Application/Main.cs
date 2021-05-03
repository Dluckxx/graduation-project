using Game.Service;
using UnityEngine;

namespace Game.Application{
    public static class Main
    {
        static ServiceContext mServiceContext = new ServiceContext();

        // Map prefab
        public static GameObject MainMap { get; set; }

        public static void Setup()
        {
            mServiceContext.Setup();

            // Load map
            if (MainMap != null)
            {
                Object.Instantiate(MainMap);
            }
            else
            {
                Debug.LogError("[Application][Main]-No map founded!");
            }
        }

        public static void TearDown()
        {
            mServiceContext.Teardown();
        }

        public static void Tick()
        {
            mServiceContext.Tick();
        }
    }
}