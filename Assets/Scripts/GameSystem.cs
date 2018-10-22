using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
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