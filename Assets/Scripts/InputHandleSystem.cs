using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandleSystem : ISystem
{
	private int skillNumber;

	public override void initialize()
	{
		//get canvas
		Transform canvas = GameObject.Find("Canvas").transform;
		if(canvas == null)
		{
			Debug.Log("Error: can not find canvas!");
			return;
		}
	}

	public override void update()
	{
		if(Input.GetMouseButton(0))
		{
			Debug.Log("charging...");
			GameSystemManager.instance.charging(true);
			GameSystemManager.instance.getPlayer().anim.SetBool("Guard", true);
			return;
		}

		if(Input.GetMouseButtonUp(0))
		{
			//cancle charging
			Debug.Log("uncharging");
			GameSystemManager.instance.charging(false);
			GameSystemManager.instance.getPlayer().anim.SetBool("Guard", true);
		}
	}
}