using UnityEngine;

namespace BBG.Events
{
    public class GameStart : MonoBehaviour
    {
        public GameEvent start;

        void Start()
        {
            start.Raise();
        }
    }
}