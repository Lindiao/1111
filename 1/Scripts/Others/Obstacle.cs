using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Enemy
{
    public override void Damage(float dmg)
    {
        if (!this.enabled) { return; }
        base.Damage(1);
        anim.SetTrigger("Hurt");
        if (hp <= 0)
        {
            anim.SetTrigger("Die");
            this.enabled = false;
        }
    }
}
