using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour {

	public float addRate = 5;
	public float subRate = 15;
	float curr = 0;
	float limit = 100;
	bool inCharging = false;

	public void charge() { inCharging = true; }
	public void unCharge() { inCharging = false; }

	// Update is called once per frame
	void Update () {
		if(inCharging)
		{
			curr += (addRate * Time.deltaTime);
			if(curr > limit) curr = limit;
		}
		else
		{
			curr = 0;
		}
	}
}
