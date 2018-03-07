using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New GameObject Variable", menuName = "BBG/Variables/GameObject")]
    public class GameObjectVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        [Tooltip("A description of the variable. [EDITOR ONLY]")]
        public string Description = "";
#endif
        [SerializeField]
        private GameObject _value;
        public GameObject Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void SetGameObjectVar(GameObjectVariable gameObjectVariable)
        {
            Value = gameObjectVariable.Value;
        }
    }
}