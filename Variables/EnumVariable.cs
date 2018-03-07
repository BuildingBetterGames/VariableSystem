using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New Enum Variable", menuName = "BBG/Variables/Enum")]
    public class EnumVariable : ScriptableObject
    {
        public int Value;
    }
}