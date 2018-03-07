using BBG.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace BBG.Updaters
{
    public class TextObserveFloat : MonoBehaviour
    {
        public FloatReference reference;
        public Text textUi;
        public bool toInt = false;

        public void Redraw()
        {
            if (toInt)
                textUi.text = reference.ToStringInt();
            else
                textUi.text = reference.ToString();
        }
    }
}