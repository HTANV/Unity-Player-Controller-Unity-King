using UnityEngine;

namespace UnityKing.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerInputHandler))]
    public class PlayerController : MonoBehaviour
    {
        [Header("References")]
        public PlayerMovement movement;
        public PlayerCamera playerCamera;
        public Animator animator;

        private PlayerInputHandler input;

        private void Awake()
        {
            movement = GetComponent<PlayerMovement>();
            input = GetComponent<PlayerInputHandler>();

            if (playerCamera == null && Camera.main != null)
                playerCamera = Camera.main.GetComponent<PlayerCamera>();
        }

        private void Update()
        {
            movement.HandleMovement(input.MoveInput, input.JumpPressed, input.SprintHeld);
            UpdateAnimator();
        }

        private void LateUpdate()
        {
            if (playerCamera != null)
                playerCamera.HandleLook(input.LookInput);
        }

        void UpdateAnimator()
        {
            if (!animator) return;

            animator.SetFloat("Speed", movement.CurrentSpeed);
            animator.SetBool("IsGrounded", movement.IsGrounded);
            animator.SetBool("IsMoving", movement.IsMoving);

            if (input.JumpPressed)
                animator.SetTrigger("Jump");
        }
    }
}
