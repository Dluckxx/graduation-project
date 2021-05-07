using System.Collections.Generic;
using UnityEngine;

namespace Game.Application{
    public class MainComponent : MonoBehaviour
    {
        public GameObject map;

        public List<string> scenes;

        private void Awake()
        {
            Main.MainMap = map;
            Main.SceneList = scenes;
            Main.Setup();
            Debug.Log("[Application][MainComponent] - Starting game ...");
        }

        private void Update()
        {
            Main.Tick();
        }

        private void OnDestroy()
        {
            Main.TearDown();
        }
    }
}