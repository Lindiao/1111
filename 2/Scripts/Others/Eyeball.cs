using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyeball : Enemy
{
    int num = 0;
    public GameObject on0;
    public GameObject on1;
    public GameObject on2;
    public GameObject on3;
    public GameObject on4;
    public GameObject on5;
    public GameObject open;
    public GameObject close;

    public override void Damage(float dmg)
    {
        if (!this.enabled) { return; }

        base.Damage(dmg);
        anim.SetTrigger("Hurt");
        if (hp <= 45 && num < 1) { anim.SetTrigger("Attack"); num++; on0.SetActive(false); on1.SetActive(true); }
        if (hp <= 35 && num < 2) { anim.SetTrigger("Attack"); num++; on1.SetActive(false); on2.SetActive(true); }
        if (hp <= 25 && num < 3) { anim.SetTrigger("Attack"); num++; on2.SetActive(false); on3.SetActive(true); }
        if (hp <= 15 && num < 4) 
        { 
            anim.SetTrigger("Attack"); 
            num++; 
            on3.SetActive(false); 
            on4.SetActive(true);
            anim.SetBool("Move", true); 
        }
        if (Game.sav.money == 10) { anim.SetBool("Move", false); }
        if (hp <= 10 && num < 5) 
        { 
            anim.SetTrigger("Attack"); 
            num++; 
            on4.SetActive(false); 
            on5.SetActive(true);
            anim.SetBool("MoveTo2", true);
            anim.SetBool("Move2", true);
        }
        if (Game.sav.money == 15) { anim.SetBool("Move2", false); anim.SetBool("MoveTo2", false); }

        if (hp <= 0)
        {
            on5.SetActive(false);
            close.SetActive(false);
            open.SetActive(true);
            anim.SetTrigger("Die");
            Destroy(nav);
            this.enabled = false;
        }
    }
}
