using System.Collections.Generic;
using UnityEngine;

namespace BBG.Variables
{
    public abstract class ListVariable<T> : ScriptableObject
    {
        public List<T> Items = new List<T>();

        public bool reset;

        private void OnEnable()
        {
            if (reset)
            {
                Items.Clear();
            }
        }

        public void Add(T item)
        {
            if (!Items.Contains(item))
                Items.Add(item);
        }

        public void Remove(T item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }
    }
}