using Renge.PPB;
using UnityEngine;
using UnityEngine.UI;

namespace UtilityAI {
    public class HealthUI : MonoBehaviour {
        [SerializeField] ProceduralProgressBar progressBar;
        [SerializeField] Button healthButton;
        [SerializeField] Button damageButton;
        [SerializeField] Health health;

        void Start() {
            healthButton.onClick.AddListener(() => Heal(10));
            damageButton.onClick.AddListener(() => TakeDamage(10));
        }
        
        void Update() {
            if (progressBar) {
                progressBar.Value = health.Current / health.maxHealth;
            }
        }
        
        void Heal(float value) => health.Heal(value);
        void TakeDamage(float damage) => health.TakeDamage(damage);
    }
}