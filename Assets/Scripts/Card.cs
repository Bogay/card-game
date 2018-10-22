using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	public event System.EventHandler OnHitHandler;
	public event System.EventHandler BeHurtHandler;
	public event System.EventHandler BeforeKilledHandler;
	public event System.EventHandler AfterKilledHandler;

	public CardInfo _test_info;

	public string cardName;
	public string element;
	public CardAttribute HP;
	public int currHP;
	public CardAttribute attack;
	public CardAttribute defense;
	public CardAttribute magicAttack;
	public CardAttribute magicDefense;
	public CardAttribute speed;
	public CardAttribute lucky;
	public Skill currentSkill;
	public List<Skill> skills;
	public bool isDead;
	public Animator anim;

	public void OnSummon(CardInfo info)
	{
		cardName = info.cardName;
		element = info.element;
		HP = new CardAttribute(info.HP);
		currHP = HP.value;
		attack = new CardAttribute(info.attack);
		defense = new CardAttribute(info.defense);
		magicAttack = new CardAttribute(info.magicAttack);
		magicDefense = new CardAttribute(info.magicDefense);
		speed = new CardAttribute(info.speed);
		lucky = new CardAttribute(info.lucky);
		skills = info.skills;
		anim = info.anim;
		
		isDead = false;
		foreach(Buff bf in info.persistence)
		{
			bf.user = this;
			bf.target = this;
			bf.OnOccur();
		}
	}

	void Update()
	{

	}

	public void OnDamaged(Card attacker, Damage dmg)
	{
		dmg.value.buffP(GameSystemManager.instance.getElementalResitance(element, attacker.element));
		int val = dmg.value.value;

		float ratio = 1;
		switch(dmg.emType)
		{
			case Damage.DAMAGE_TYPE.PHYSICAL:
				ratio = ((float)defense.value / (100 + defense.value));
				break;
			case Damage.DAMAGE_TYPE.MAGICAL:
				ratio = ((float)magicDefense.value / (100 + magicDefense.value));
				break;
			case Damage.DAMAGE_TYPE.REAL:
				ratio = 1;
				break;
			default:
				Debug.Log(System.String.Format("Error: unrecongnized damage type [{0}] from [{1}]", dmg.emType, attacker.cardName));
				break;
		}

		currHP -= (int)(val * ratio);
		if(currHP <= 0)
		{
			if(BeforeKilledHandler != null) BeforeKilledHandler(this, System.EventArgs.Empty);
		}
		
		if(isDead)
		{
			die();
		}
	}

	public void die()
	{

	}
}