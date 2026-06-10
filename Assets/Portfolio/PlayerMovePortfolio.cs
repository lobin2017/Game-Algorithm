using UnityEngine;
using UnityEngine.InputSystem;

namespace Portfolio
{
    public class PlayerMovePortfolio : MonoBehaviour
    {
        public float moveSpeed = 5f;

        void Update()
        {
            bool isMoving;
            Vector2 inputVector = Vector2.zero;

            if (Keyboard.current != null)
            {
                if (Keyboard.current.aKey.isPressed) inputVector.x = -1;
                if (Keyboard.current.dKey.isPressed) inputVector.x = 1;
                if (Keyboard.current.wKey.isPressed) inputVector.y = 1;
                if (Keyboard.current.sKey.isPressed) inputVector.y = -1;
            }
            Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y).normalized;
            isMoving = (moveDir.magnitude > 0);
            if (isMoving)
            {
                transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
            }
        }
    }
}