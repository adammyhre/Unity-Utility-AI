using UnityEngine;
using UnityEngine.AI;

namespace UtilityAI {
    public class AnimationController : MonoBehaviour {
        Animator animator;
        NavMeshAgent agent;
        readonly int speedHash = Animator.StringToHash("Speed");
        float currentSpeed = 0f; // Current speed with damping
        float speedVelocity = 0f; // Velocity used by SmoothDamp
        public float smoothTime = 0.3f; // Smooth time, adjust as needed

        void Start() {
            animator = GetComponentInChildren<Animator>();
            agent = GetComponent<NavMeshAgent>();
        }

        void Update() {
            float targetSpeed = agent.velocity.magnitude;
            // Smoothly interpolate the current speed towards the target speed
            currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, smoothTime);
            animator.SetFloat(speedHash, currentSpeed);
        }
    }
}