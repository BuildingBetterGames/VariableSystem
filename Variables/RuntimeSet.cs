using BBG.Behaviours;
using UnityEngine;

namespace BBG.Variables
{
    [CreateAssetMenu(fileName = "New RuntimeSet", menuName = "BBG/Variables/RuntimeSet")]
    public class RuntimeSet : ListVariable<ActiveObject>
    {
    }
}