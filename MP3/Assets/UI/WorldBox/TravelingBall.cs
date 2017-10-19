using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelingBall : MonoBehaviour {

    //Direction of the target ball
    public Vector3 dir;

    //Speed to move
    public float speed, aliveTime;

    TravelingBallControl controls;

    WorldBox world;

    Vector3 end;

    float timer;

    void Start()
    {
        controls = GameObject.Find("TravelingBallSliders").GetComponent<TravelingBallControl>();
        world = GameObject.Find("WorldBox").GetComponent<WorldBox>();
        GetComponent<Renderer>().material = Resources.Load("Black") as Material;
        speed = controls.getSpeed();
        aliveTime = controls.getAliveTime();
        dir = world.aim;
        end = world.end.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += dir * speed * Time.deltaTime;
        timer = timer + Time.deltaTime;

        if (timer > aliveTime || transform.localPosition.x > end.x) { Destroy(gameObject); }
	}
}
