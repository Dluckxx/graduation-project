using Game.Service;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Application{
    public static class Main
    {
        // Map prefab
        public static GameObject MainMap { get; set; }
        public static List<string> SceneList { get; set; }

        public static void Setup()
        {
            ServiceContext.Setup();
            LoadMap();
            LoadScene();
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

        private static void LoadScene()
        {
            foreach(string name in SceneList)
            {
                SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
            }
        }
    }
}