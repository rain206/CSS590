using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelingBallControl : MonoBehaviour {

    //Reference to the sliders in the control
    public TargetBallSliders interval, speed, alive;

	// Use this for initialization
	void Start () {
        //TODO: Set the min and max for the sliders along with the starting values
        interval.slider.minValue = 0.5f;
        interval.slider.maxValue = 4;
        interval.slider.value = 1;

        speed.slider.minValue = 0.5f;
        speed.slider.maxValue = 15;
        speed.slider.value = 6;

        alive.slider.minValue = 1;
        alive.slider.maxValue = 15;
        alive.slider.value = 10;
	}
	

    //Returns the value of the interval slider
    public float getInterval() { return interval.slider.value; }

    //Returns the value of the speed slider
    public float getSpeed() { return speed.slider.value; }

    //Return the amount of time to be alive
    public float getAliveTime() { return alive.slider.value; }
}
