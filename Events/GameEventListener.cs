using UnityEngine;
using UnityEngine.Events;

namespace BBG.Events
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent Event;
        public UnityEvent Response;

        public void OnRaised()
        {
            Response.Invoke();
        }

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }
    }
}