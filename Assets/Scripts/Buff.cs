using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : MonoBehaviour
{
    protected Card user;
    protected Card target;
    protected float tickGap; //how long it call onTick() once
    protected float tickTimer = 0; //reocrd the time since last call of onTick()
    protected float maintainTime; //how long it should exist
    protected float exsitTime = 0; //how long the buff has been existed

    public void setUser(Card u) { user = u; }
    public void setTarget(Card t) { target = t; }

    public virtual void OnOccur() {}
    public virtual void OnHit() {}
    public virtual void BeHurt() {}
    public virtual void OnTick() {}
    public virtual void OnRemoved() {}
    public virtual void BeforeKilled() {}
    public virtual void AfterKilled() {}

    void Update()
    {
        
    }
}