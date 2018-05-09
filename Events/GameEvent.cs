using System.Collections.Generic;
using UnityEngine;

namespace BBG.Events
{
    [CreateAssetMenu(fileName = "New GameEvent", menuName = "BBG/Events/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void RegisterListener(GameEventListener _listener)
        {
            if (!listeners.Contains(_listener))
            {
                listeners.Add(_listener);
            }
        }

        public void UnregisterListener(GameEventListener _listener)
        {
            if (listeners.Contains(_listener))
            {
                listeners.Remove(_listener);
            }
        }

        public void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnRaised();
            }
        }
    }
}