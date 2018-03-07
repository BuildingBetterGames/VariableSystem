using BBG.Variables;
using UnityEngine;

namespace BBG.Behaviours
{
    public class ActiveObject : MonoBehaviour
    {
        public RuntimeSet dataSet;

        private void OnEnable()
        {
            dataSet.Add(this);
        }

        private void OnDisable()
        {
            dataSet.Remove(this);
        }
    }
}