using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlimeBoss : Enemy {
    
    void Update()
    {
        StateMachine();
        if (target != null)
        {
            nav.Follow(target);
        }
    }

    public override void StateMachine()
    {
        anim.SetBool("moving", nav.moving);
    }

    public override void Damage(float dmg)
    {
        if (!this.enabled) { return; }

        base.Damage(dmg);
        if (hp > 50) { anim.SetTrigger("Hurt"); }
        else if (hp > 25) { anim.SetTrigger("Weak"); }
        else if (hp > 0) { anim.SetTrigger("Violent"); }

        if (hp <= 0)
        {
            anim.SetTrigger("Die");
            Destroy(nav);
            this.enabled = false;
        }
    }
}
