﻿using UnityEngine;
using System.Collections;

public class MainCharacter : MonoBehaviour {
	
	public float moveSpeed;
	// Use this for initialization
	void Start () 
	{
		moveSpeed = 8.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0.0f,0.0f);
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce(0,500,0);
		}
	}
}
