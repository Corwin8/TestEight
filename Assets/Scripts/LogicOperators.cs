using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour {

	public int A;
	public int B;
	public int Average;

	// Use this for initialization
	void Start ()
	{
		Average = (A + B) / 2;
		Debug.Log(Average);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
