using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : MonoBehaviour
{
    public Card user;
    public Card target;
    protected float tickGap; //how long it call onTick() once
    protected float maintainTime; //how long it should exist

    public virtual void OnOccur() {}
    public virtual IEnumerator OnTick() { yield return new WaitForSeconds(tickGap); }
    public virtual void OnHit(object sender, System.EventArgs e) {}
    public virtual void BeHurt(object sender, System.EventArgs e) {}
    public virtual void OnRemoved(object sender, System.EventArgs e) {}
    public virtual void BeforeKilled(object sender, System.EventArgs e) {}
    public virtual void AfterKilled(object sender, System.EventArgs e) {}

    public Buff(Card u, Card t)
    {
        user = u;
        target = t;
    }

    void Start()
    {
        if(maintainTime > 0)
            Destroy(this, maintainTime);
    }
}