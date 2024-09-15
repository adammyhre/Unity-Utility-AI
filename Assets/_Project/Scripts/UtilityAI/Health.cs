using UnityEngine;

namespace UtilityAI {
    public class Health : MonoBehaviour {
        public float maxHealth = 100;
        public float Current;
        public float normalizedHealth => Current / maxHealth;

        void Start() {
            Current = maxHealth;
        }
        
        public void Heal(float value) {
            Current += value;
        }

        public void TakeDamage(float damage) {
            Current -= damage;
            if (Current <= 0) {
                Die();
            }
        }

        void Die() {
            // Destroy(gameObject);
        }
    }
}