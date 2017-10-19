using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour {

    //Reference to the gameobject representing this target
    public GameObject obj;

    //Reference to the wall object this target sits on
    public WallScript wall;

    //Gameobject can be dragged across the wall as the user pleases
    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                obj.transform.position = new Vector3(wall.transform.position.x, hit.point.y, hit.point.z);
            }
        }
    }
}
