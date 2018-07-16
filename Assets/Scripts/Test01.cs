using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour {

	public int MyHealth = 100;
	public bool Alive = false;

	// Use this for initialization
	void Start()
	{
		if (MyHealth == 0)
		{
			Alive = false;
		}
		else if (MyHealth < 0)
		{
			Alive = false;
		}
		else
		{
			Alive = true;
		}

		if (Alive == true)
		{
			Debug.Log("I'm alive.");
		}
		else
		{
			Debug.Log("Sadly, I'm no longer alive.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
