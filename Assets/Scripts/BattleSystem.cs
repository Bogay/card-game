using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleSystem : ISystem
{
	public Team left;
	public Team right;
	private int leftRemain;
	private int rightRemain;

	public override void initialize()
	{
		leftRemain = 1; //left.numberOfMember;
		rightRemain = 1; //right.numberOfMember;

		foreach(Card c in left.members)
		{
			c.OnSummon(c._test_info);
			c.AfterKilledHandler += OnCardKilled;
		}
		foreach(Card c in right.members)
		{
			c.OnSummon(c._test_info);
			c.AfterKilledHandler += OnCardKilled;
		}
	}

	public Card getPlayer() { return left.curr; }

	public override void update()
	{
		if(leftRemain==0 || rightRemain==0)
		{
			SceneManager.LoadScene("EndScene");
		}
	}

	private void OnCardKilled(object sender, System.EventArgs e)
	{
		if(!(sender is Card))
		{
			Debug.Log("Error: the sender isn't a instance of Card");
			return;
		}
		if(left.members.Contains((Card)sender)) { leftRemain--; return; }
		if(right.members.Contains((Card)sender)) { rightRemain--; return; }
		Debug.Log(System.String.Format("Error: Can't find [{0}] on the scene.", sender));
	}
}