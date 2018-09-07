﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Vector3 screenPoint, offset;
    private bool isDragged = false, resetting = false;
    public GameObject edgeUp, edgeDown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0))
        {
            isDragged = true;
        }else if (Input.GetMouseButtonUp(0))
        {
            isDragged = false;
        }
        if (isDragged)
        {
            this.transform.position = new Vector3(this.transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, this.transform.position.z);
        }
       
    }
}
