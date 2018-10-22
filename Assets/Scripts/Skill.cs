using System.Collections;
using System.Collections.Generic;

public class Skill
{
    public Card user { get; protected set; }
    public Card target;
    public string name { get; protected set; }
    public string desc { get; protected set; }
    public float cost { get; protected set; }

    public Skill(Card u, Card t)
    {
        user = u;
        target = t;
    }

    public bool Cast()
    {
        if(BeforeCasting()) return false;
        OnCasted();
        AfterCasted();
        return true;
    }

    // called before skill casted. check whether the skill can cast.
    public virtual bool BeforeCasting() { return true; } //user.energy.curr < cost; }
    // the main logic of skill. do damage, heal or anything it should do.
    public virtual void OnCasted() {}
    // called after skill casted.
    public virtual void AfterCasted() {}

    public class NormalAttack : Skill
    {
        public NormalAttack(Card u, Card t) : base(u, t)
        {
            name = "Attack";
            cost = 0;
        }

        public override void OnCasted()
        {
            target?.OnDamaged(user, new Damage(user.attack.value, Damage.DAMAGE_TYPE.PHYSICAL));
        }
    }
}