using UnityEngine;

namespace Game.Application{
    public class MainComponent : MonoBehaviour
    {
        public GameObject map;

        private void Awake()
        {
            Main.MainMap = map;

            Main.Setup();
            Debug.Log("[Application] [MainComponent] - Starting game ...");
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