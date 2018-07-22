using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	public event System.EventHandler BeHurtHandler;
	public event System.EventHandler BeforeKilledHandler;
	public event System.EventHandler AfterKilledHandler;
	public event System.EventHandler OnHitHandler;

	CardInfo info = null;
	public Buffable HP;
	public int currHP;
	public Buffable attack;
	public Buffable defense;
	public Buffable magicAttack;
	public Buffable magicDefense;
	public Buffable speed;
	public Buffable lucky;
	public Energy energy;
	public List<Skill> skills;

	public void setInfo(CardInfo ci)
	{
		if (info) return;
		info = ci;
	}

	public void OnSummon()
	{
		HP = new Buffable(info.HP);
		currHP = HP.getValue();
		attack = new Buffable(info.attack);
		defense = new Buffable(info.defense);
		magicAttack = new Buffable(info.magicAttack);
		magicDefense = new Buffable(info.magicDefense);
		speed = new Buffable(info.speed);
		lucky = new Buffable(info.lucky);
		energy = Instantiate(energy);
		skills = (info.skills);
		foreach (Buff bf in info.persistence)
		{
			bf.setUser(this);
			bf.setTarget(this);
			bf.OnOccur();
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}