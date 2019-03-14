using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createOutlet : MonoBehaviour 
{
	Material planeColor;

	// Use this for initialization
	void Start () 
	{
		planeColor = Resources.Load("planeColor", typeof(Material)) as Material;

		GameObject plane  = GameObject.CreatePrimitive(PrimitiveType.Plane);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0,0);
		cube.transform.localScale -= new Vector3(0.7f, 0.9f, 0.8f);
		Renderer cubeRend = cube.GetComponent<Renderer>();
		cubeRend.material = planeColor;
	}
}
