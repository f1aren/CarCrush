using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampPost : MonoBehaviour {

	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!SpawnBarriers.isGameOver) {
            transform.Translate(new Vector3(0, BlocksBehaviour.speed, 0) * Time.deltaTime);
        }

		if (transform.position.y <= -8f && transform.position.x < 0) {
            //Destroy(gameObject);
			transform.position = new Vector3(-3f, 7f, -1.9f);
        } else if (transform.position.y <= -8f && transform.position.x > 0) {
			transform.position = new Vector3(3f, 7f, -1.9f);
		}
	}
}
