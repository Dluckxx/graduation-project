using System.Collections;
using UnityEngine;

namespace Game.UI.Components
{
    public class PauseMenuComponent : MonoBehaviour
    {
        public GameObject AreaButtonPrefab;

        private PauseMenu mPauseMenu;

        // Use this for initialization
        void Start()
        {
            mPauseMenu = new PauseMenu();
            mPauseMenu.bIsShow = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void CheckEsc()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                mPauseMenu.bIsShow = !mPauseMenu.bIsShow;
            }
        }
    }
}