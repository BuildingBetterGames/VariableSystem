using BBG.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace BBG.Updaters
{
    public class TextObserveString : MonoBehaviour
    {
        public StringReference reference;
        public Text textUi;

        public void Redraw()
        {
            textUi.text = reference.Value;
        }
    }
}