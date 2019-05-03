using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksBehaviour : MonoBehaviour {

    public static float speed {get; set;}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!SpawnBarriers.isGameOver) {
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
        if (transform.position.y < -7f) {
            Destroy(gameObject);
        }
	}
}
