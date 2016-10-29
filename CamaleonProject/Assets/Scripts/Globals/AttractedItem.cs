using UnityEngine;
using System.Collections;

public class AttractedItem : MonoBehaviour {

	public GameObject mc;
	public float AttractionForce;
	Rigidbody rb;
	Vector3 vectorDir ;
	// Use this for initialization
	void Start () 
	{
		rb = mc.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		vectorDir = GetComponent<Rigidbody>().position - rb.GetComponent<Rigidbody>().position;
		vectorDir.Normalize();

		if(Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody>().AddRelativeForce(-vectorDir* AttractionForce);

		}


	}
}
