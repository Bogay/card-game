using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAffectSystem : ISystem
{
	protected Dictionary<string, string> table = new Dictionary<string, string>();
	
	public int getValue(string  a, string  b)
	{
		if(table.ContainsKey(a))
		{
			if(table[a].Equals(b)) return 50;
		}
		else if(table.ContainsKey(b))
		{
			if(table[b].Equals(a)) return -50;
		}
		return 0;
	}
}