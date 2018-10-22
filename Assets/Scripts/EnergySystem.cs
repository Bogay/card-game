using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : ISystem
{
	public bool inCharging = false;
	public float addRate = 5;
	public float subRate = 15;
	public float curr { get; private set; } = 0;
	private float limit = 100;

	public void reset() { curr = 0; }
	public override void update()
	{
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