using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    //Reference to a gameobject used as a target
    public TargetScript target;

    //Screen Point
    Vector3 screenPoint;

    //offset
    Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Moves the target to the location the user clicks
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(target.transform.position);
        offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(
                                            Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                target.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }
        }
    }
}
