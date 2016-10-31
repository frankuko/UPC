using UnityEngine;
using System.Collections;

public class AttractedItem : MonoBehaviour {

	public GameObject mc;
	public float AttractionForce;
	Rigidbody rb;
	public GameObject pj;
	float radius = 5f;
	float force = 50f;

	Vector3 vectorDir ;
	// Use this for initialization
	void Start () 
	{
		rb = mc.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		pj = GameObject.Find("Personaje");
		mc = GameObject.Find ("Atraido");
		vectorDir = GetComponent<Rigidbody>().position - mc.transform.position;
		vectorDir.Normalize();

		if(Input.GetKey(KeyCode.X))
		{
			Vector3 magnetField = mc.transform.position - pj.transform.position;
	

			float index = (radius/magnetField.magnitude*300);
			print (index);
			print(GetComponent<Rigidbody>().transform.position);
			GetComponent<Rigidbody>().AddForce(-force*magnetField.normalized*Mathf.Abs(index));

		}


	}
}
