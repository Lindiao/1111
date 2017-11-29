using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDie : Enemy {

    public override void Damage(float dmg)
    {
        if (!this.enabled) { return; }
        base.Damage(1);
    }
}
