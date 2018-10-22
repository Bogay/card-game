using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPool : MonoBehaviour
{

	public CardInfo[] cards;
	
	private int totalWeight = 0;

	// Use this for initialization
	void Start()
	{
		foreach (CardInfo c in cards) totalWeight += c.weight;
	}

	public CardInfo pick()
	{
		int p = Random.Range(1, totalWeight);
		int t = 0;
		foreach (CardInfo c in cards)
		{
			t += c.weight;
			if (t >= p) return c;
		}
		return null;
	}

	public void click()
	{
		Debug.Log(pick().cardName);
	}
}