using UnityEngine;

namespace UtilityAI {
    [CreateAssetMenu(menuName = "UtilityAI/Considerations/Constant")]
    public class ConstantConsideration : Consideration {
        public float value;
        
        public override float Evaluate(Context context) => value;
    }
}