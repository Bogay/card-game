using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AttackControl : MonoBehaviour
{

	Animator anim;

	// Use this for initialization
	void Start()
	{
		anim = gameObject.GetComponent<Animator>();
	}

	public void Attak()
	{
		anim.SetTrigger("attacking");
	}
}