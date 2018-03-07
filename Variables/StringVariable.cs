using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New String Variable", menuName = "BBG/Variables/String")]
    public class StringVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        [Tooltip("A description of the variable. [EDITOR ONLY]")]
        public string Description = "";
#endif
        [SerializeField]
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        [SerializeField]
        [Tooltip("Resets value to default value at runtime.")]
        private bool resetValue;
        [SerializeField]
        private string defaultValue;

        private void OnEnable()
        {
            if (resetValue)
                _value = defaultValue;
        }
    }
}