using Game.Service;
using UnityEngine;

namespace Game.Application{
    public static class Main
    {
        // Map prefab
        public static GameObject MainMap { get; set; }

        public static void Setup()
        {
            ServiceContext.Setup();
            LoadMap();
        }

        public static void TearDown()
        {
            ServiceContext.Teardown();
        }

        public static void Tick()
        {
            ServiceContext.Tick();
        }

        private static void LoadMap()
        {
            if (MainMap != null)
            {
                Object.Instantiate(MainMap);
            }
            else
            {
                Debug.LogError("[Application][Main] - No map founded!");
            }
        }
    }
}