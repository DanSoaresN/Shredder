using UnityEngine;
using UnityEngine.InputSystem;

namespace TopDown.Movement
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerMovement : Mover
    {
        private void OnMove(InputValue inputValue)
        {
            Vector3 pInput = new Vector3(inputValue.Get<Vector2>().x, inputValue.Get<Vector2>().y, 0); 
            CInput = pInput;
        }
    }
}
