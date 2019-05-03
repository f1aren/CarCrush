using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMySphere : MonoBehaviour {

	//private GameObject myObject;
	private Vector2 centerOfCircle;
	private float angle;
	public float radius = 1f;
	public float speed = 1f;
	
	public float x, y;
	
	//float 
		
	// Use this for initialization
	void Start () {
		centerOfCircle = transform.position;
		//myObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		angle += Time.deltaTime;
		x = Mathf.Cos(angle * speed) * radius;
      	y = Mathf.Sin(angle * speed) * radius;
		//myObject.transform.Translate(new Vector3(1 * Time.deltaTime, 1 * Time.deltaTime, 0));
		transform.position = centerOfCircle + new Vector2(x, y);
	}
}
