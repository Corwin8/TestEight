using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public GameObject[] myObjects;

	// Use this for initialization
	void Start () {
		foreach (var gameObject in myObjects)
		Debug.Log(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
