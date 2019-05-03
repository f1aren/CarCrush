using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAnim : MonoBehaviour {

    private Animator animator;
	public float denominatorSpeed = 2.5f;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.speed = -BlocksBehaviour.speed / denominatorSpeed;
	}
}
