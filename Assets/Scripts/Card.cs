using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

	public event System.EventHandler BeHurtHandler;
	public event System.EventHandler BeforeKilledHandler;
	public event System.EventHandler AfterKilledHandler;
	public event System.EventHandler OnHitHandler;

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

	private ElementalDamageAffect _elemAff;

	public void OnSummon(CardInfo info)
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
		skills = info.skills;
		foreach (Buff bf in info.persistence)
		{
			bf.setUser(this);
			bf.setTarget(this);
			bf.OnOccur();
		}
	}

	void Start()
	{
		_elemAff = GameObject.Find("/Systems").GetComponent<ElementalDamageAffect>();
	}

	void Update()
	{

	}
}