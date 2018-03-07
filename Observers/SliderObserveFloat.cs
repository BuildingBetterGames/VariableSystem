using BBG.Variables;
using UnityEngine;
using UnityEngine.UI;

namespace BBG.Updaters
{
    public class SliderObserveFloat : MonoBehaviour
    {
        public FloatReference current;
        public FloatReference max;

        public Slider sliderUi;

        public void Redraw()
        {
            sliderUi.value = Mathf.Clamp01(current / max);
            if (sliderUi.value == 0)
            {
                sliderUi.fillRect.gameObject.SetActive(false);
            }
            else
            {
                sliderUi.fillRect.gameObject.SetActive(true);
            }
        }
    }
}