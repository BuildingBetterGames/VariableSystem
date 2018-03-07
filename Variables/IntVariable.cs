using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New Integer Variable", menuName = "BBG/Variables/Integer")]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        [Tooltip("A description of the variable. [EDITOR ONLY]")]
        public string Description = "";
#endif
        [SerializeField]
        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [SerializeField]
        [Tooltip("Resets value to default value at runtime.")]
        private bool resetValue;
        [SerializeField]
        private int defaultValue;

        private void OnEnable()
        {
            if (resetValue)
                _value = defaultValue;
        }

        public void Add(int amount)
        {
            _value += amount;
        }
    }
}