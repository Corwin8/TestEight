using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int[] Numbers = {5, 6, 7, 8};

	// Use this for initialization
	void Start ()
	{
		foreach (var number in Numbers)
		{
			Debug.Log(number);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
