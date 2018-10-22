using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "CardGame/CardInfo", order = 2)]
public class CardInfo : ScriptableObject {
	public string cardName;
	[TextArea(2, 3)]
	public string desc;
	public string element;
	public int HP;
	public int attack;
	public int defense;
	public int magicAttack;
	public int magicDefense;
	public int speed;
	public int lucky;
	public int weight;

	public List<Buff> persistence;
	public List<Skill> skills;

	public Animator anim;
}
