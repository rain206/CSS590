using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBox : MonoBehaviour {

    //Reference to the start and end points
    public TargetScript start, end;

    //Reference to the aim line
    public GameObject aimLine;

    //Represents the walls in the WorldBox
    public WallScript leftWall, rightWall, backWall, floor;

    //Reference to the traveling ball object
    public GameObject travelingBall;

    //Reference to the Target Ball Controls
    public TravelingBallControl TargetBallControls;

    //Current direction between the start and end points
    public Vector3 aim;

    float timer;

	// Use this for initialization
	void Start () {
        //TODO: Set floot and back targets
        start.wall = leftWall;
        end.wall = rightWall;
        leftWall.target = start;
        rightWall.target = end;

        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {

        //Set the direction of aimLine
        aim = rightWall.target.transform.localPosition - leftWall.target.transform.localPosition;
        aimLine.transform.localRotation = Quaternion.FromToRotation(Vector3.up, aim);

        //Set length and position of aimLine
        aimLine.transform.localPosition = (leftWall.target.transform.localPosition + rightWall.target.transform.localPosition) / 2;
        Vector3 size = new Vector3(aimLine.transform.localScale.x, aim.magnitude / 2, aimLine.transform.localScale.z);
        aimLine.transform.localScale = size;

        //TODO:Create a traveling ball that uses the interval, speed, and alive values from the "traveling ball sliders"
        timer = timer + Time.deltaTime;
        if (timer > TargetBallControls.getInterval()) //Create a new ball
        {
            CreateTargetBall();
            timer = 0;
        }
    }

    void CreateTargetBall()
    {
        GameObject traveler = Instantiate(travelingBall, start.obj.transform.localPosition, Quaternion.identity) as GameObject;
    }
}
