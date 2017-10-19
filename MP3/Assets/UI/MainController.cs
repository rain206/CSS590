using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    //Reference to the World
    public WorldBox worldBox;

    //Reference to the Target Ball Control UI panel
    public TravelingBallControl targetBallControl;


	// Use this for initialization
	void Start () {
        worldBox.TargetBallControls = targetBallControl;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
