using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalDamageAffect : DamageAffect
{
	void Start()
	{
		table.Add("water", "fire");
		table.Add("fire", "earth");
		table.Add("earth", "water");
		table.Add("dark", "ligth");
		table.Add("ligth", "dark");
	}
}