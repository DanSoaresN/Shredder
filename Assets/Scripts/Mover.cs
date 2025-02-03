using UnityEngine;

namespace TopDown.Movement
{
    [RequireComponent (typeof (Rigidbody2D))]

    public class Mover : MonoBehaviour
    {
        [SerializeField] private float MSpeed;
        private Rigidbody2D rb;
        protected Vector3 CInput;

        private void Awake()
        {
           rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            rb.linearVelocity = MSpeed * CInput * Time.fixedDeltaTime;
        }
    }
}