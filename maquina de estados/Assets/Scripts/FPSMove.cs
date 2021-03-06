﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
	public float speed;

	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
			transform.position += transform.forward* speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
			transform.position -= transform.forward * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.A))
        {
			transform.position -= transform.right * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.D))
        {
			transform.position += transform.right * speed * Time.deltaTime;
        }
	}
}
