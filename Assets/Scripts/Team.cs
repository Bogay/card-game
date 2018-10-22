using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : ScriptableObject
{
	public Card curr { get; private set; }
	public List<Card> members = new List<Card>();
	public int numberOfMember { get { return members.Count; } }

	public void initialize() { curr =  members[0]; }
}
