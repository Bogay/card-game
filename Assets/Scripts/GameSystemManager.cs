using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManager
{
	public static GameSystemManager instance
	{
		get
		{
			if(_instance == null) _instance = new GameSystemManager();
			return _instance;
		}
	}
	private static GameSystemManager _instance = null;
	private BattleSystem battleSystem = new BattleSystem();
	private ElementalDamageAffectSystem elementalDamageAffectSystem = new ElementalDamageAffectSystem();
	private EnergySystem energySystem = new EnergySystem();
	private InputHandleSystem inputHandleSystem = new InputHandleSystem();

	public void initialize()
	{
		battleSystem.initialize();
		elementalDamageAffectSystem.initialize();
		inputHandleSystem.initialize();
	}

	public void update()
	{
		//Debug.Log("Game update!");
		battleSystem.update();
		inputHandleSystem.update();
	}

	public float getCurrentEnergy() { return energySystem.curr; }

	public int getElementalResitance(string a, string b)
	{
		return elementalDamageAffectSystem.getValue(a, b);
	}

	public Card getPlayer() { return battleSystem.getPlayer(); }
	public void charging(bool stat) { energySystem.inCharging = stat; }
}
