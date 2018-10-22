using System.Collections;
using System.Collections.Generic;

public class Damage
{
	public enum DAMAGE_TYPE
	{
		PHYSICAL,
		MAGICAL,
		REAL
	};

	public DAMAGE_TYPE emType { get; } = DAMAGE_TYPE.PHYSICAL;
	public CardAttribute value;

	public Damage(int val, DAMAGE_TYPE ty)
	{
		value = new CardAttribute(val);
		emType = ty;
	}
}