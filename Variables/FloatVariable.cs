using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New Float Variable", menuName = "BBG/Variables/Float")]
    public class FloatVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        [Tooltip("A description of the variable. [EDITOR ONLY]")]
        public string Description = "";
#endif
        [SerializeField]
        private float _value;
        public float Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [SerializeField]
        [Tooltip("Resets value to default value at runtime.")]
        private bool resetValue;
        [SerializeField]
        private float defaultValue;

        private void OnEnable()
        {
            if (resetValue)
                _value = defaultValue;
        }

        public void Add(float amount)
        {
            _value += amount;
        }
    }
}