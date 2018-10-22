using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManagerComponent : MonoBehaviour
{
	void Start()
	{
		GameSystemManager.instance.initialize();
	}

	void Update()
	{
		GameSystemManager.instance.update();
	}
}