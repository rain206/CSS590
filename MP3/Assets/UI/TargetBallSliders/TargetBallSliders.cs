using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetBallSliders : MonoBehaviour {

    //Reference to the slider
    public Slider slider;

    //Value to display on the slider
    public Text valueText;


    //Updates the slider and the text displayed when the user moves the UI slider.
    public void SliderEvent(float value)
    {
        slider.value = value;
        valueText.text = string.Format("{0:0.0000}", value);
    }
}
