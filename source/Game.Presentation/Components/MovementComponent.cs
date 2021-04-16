using UnityEngine;

namespace Game.Presentation.Components{
    public class MovementComponent : MonoBehaviour{
        [SerializeField] private Transform mTransform;
        [SerializeField] private Vector3 mLocationOffset;
        [SerializeField] private Vector3 mRotationOffset;
        [SerializeField] private bool bIsBoost;

        [Header("Sensitive")] public float mMoveSpeed = 1.0F;
        public float mViewSpeed = 100.0F;
        public float mBoostScale = 8.0F;

        private void Start() {
            mTransform = gameObject.GetComponent<Transform>();
            mLocationOffset = new Vector3();
            mRotationOffset = new Vector3();

            // Lock the Cursor.
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update() {
            CalculateLocationOffset();
            CalculateRotationOffset();
            CalculateBoost();
            DoMovement();
        }

        private void CalculateBoost() {
            if (Input.GetKey(KeyCode.LeftShift)) {
                if (bIsBoost) return;
                mMoveSpeed *= mBoostScale;
                bIsBoost = true;
            } else {
                if (!bIsBoost) return;
                mMoveSpeed /= mBoostScale;
                bIsBoost = false;
            }
        }

        // Apply the movement to gameObject.
        private void DoMovement() {
            mTransform.Translate(mLocationOffset * (mMoveSpeed * Time.deltaTime), Space.Self);
            // Rotate around left-right
            mTransform.Rotate(mRotationOffset.x * (mViewSpeed * Time.deltaTime), 0, 0);
            // Rotate around top-bottom
            mTransform.Rotate(0, mRotationOffset.y * (mViewSpeed * Time.deltaTime),0, Space.World);
        }

        // Do calculate the movement vector3 offset from input.
        private void CalculateLocationOffset() {
            mLocationOffset = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) {
                mLocationOffset += Vector3.forward;
            }

            if (Input.GetKey(KeyCode.S)) {
                mLocationOffset += Vector3.back;
            }

            if (Input.GetKey(KeyCode.A)) {
                mLocationOffset += Vector3.left;
            }

            if (Input.GetKey(KeyCode.D)) {
                mLocationOffset += Vector3.right;
            }

            if (Input.GetKey(KeyCode.Space)) {
                mLocationOffset += mTransform.InverseTransformDirection(Vector3.up);
            }

            if (Input.GetKey(KeyCode.LeftControl)) {
                mLocationOffset += mTransform.InverseTransformDirection(Vector3.down);
            }
        }

        private void CalculateRotationOffset() {
            mRotationOffset.x = -Input.GetAxis("Mouse Y");
            mRotationOffset.y = Input.GetAxis("Mouse X");
        }
    }
}