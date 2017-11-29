using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEyeball : Enemy {
    int num = 0;
    public override void Damage(float dmg)
    {
        if (!this.enabled) { return; }

        base.Damage(dmg);
        anim.SetTrigger("Hurt");
        if(hp <= 100 && num < 1) { anim.SetTrigger("Attack");num++; }
        if (hp <= 75 && num < 2) { anim.SetTrigger("Attack"); num++; }
        if (hp <= 50 && num < 3) { anim.SetTrigger("Attack"); num++; }
        if (hp <= 25 && num < 4) { anim.SetTrigger("Attack"); num++; }

        if (hp <= 0)
        {
            anim.SetTrigger("Die");
            Destroy(nav);
            this.enabled = false;
        }
    }
}
