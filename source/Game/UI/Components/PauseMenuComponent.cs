using UnityEngine;

namespace Game.UI.Components
{
    public class PauseMenuComponent : MonoBehaviour
    {

        public bool bShow = false;

        // Update is called once per frame
        void Update()
        {
            CheckEsc();
            UpdateShow();
        }

        private void CheckEsc()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                bShow = !bShow;
            }
        }

        private void UpdateShow()
        {
            GetComponent<Canvas>().enabled = bShow;

            // Lock the Cursor.
            Cursor.visible = bShow;
            Cursor.lockState = (bShow ? CursorLockMode.Confined : CursorLockMode.Locked);
        }
    }
}