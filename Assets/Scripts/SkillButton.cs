using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
	public int number; //the skill number
	private Button button;

	private void Start()
	{
		button = GetComponent<Button>();
		if(number<1 || number>3)
		{
			Debug.Log(System.String.Format("Warning: the button [{0}] skill number is out of range! (should be 1~3.)", gameObject.name));
		}
	}

	private void OnMouseUp()
	{
		Debug.Log(System.String.Format("Cast skill [{0}].", number));
		GameSystemManager.instance.getPlayer().anim.SetTrigger("Skill" + number);
	}
}