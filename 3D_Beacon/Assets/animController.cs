using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		//anim["beaconAnimation"].wrapMode = WrapMode.Once;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown)
		{
			anim.Play("beaconAnimation");
			//anim.StopPlayback("beaconAnimation");
		}
	}
}
