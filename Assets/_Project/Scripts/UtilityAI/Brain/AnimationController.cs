using UnityEngine;
using UnityEngine.AI;

namespace UtilityAI {
    public class AnimationController : MonoBehaviour {
        Animator animator;
        NavMeshAgent agent;
        readonly int speedHash = Animator.StringToHash("Speed");
        float currentSpeed;
        float speedVelocity;
        public float smoothTime = 0.3f;

        void Start() {
            animator = GetComponentInChildren<Animator>();
            agent = GetComponent<NavMeshAgent>();
        }

        void Update() {
            float targetSpeed = agent.velocity.magnitude;
            
            currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, smoothTime);
            animator.SetFloat(speedHash, currentSpeed);
        }
    }
}