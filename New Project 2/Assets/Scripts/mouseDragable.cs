using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDragable : MonoBehaviour {
    double offsetX;
    double offsetY;
	// Use this for initialization
	public void dragStart() {
        offsetX = Input.mousePosition.x;
        offsetY = Input.mousePosition.y;
    }
	
	// Update is called once per frame
	public void drag() {
       transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
	}
}
