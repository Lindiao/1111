using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour {
    public float dmg = 1.0f;
    public TargetType type = TargetType.Enemy;

    void OnTriggerEnter2D(Collider2D co)
    {
        switch((int)type)
        {
            case 0:
                if(co.gameObject.layer == 11)
                {
                    co.GetComponent<Enemy>().Damage(dmg);
                }
                break;
            case 1:
                if (co.gameObject.layer == 9)
                {
                    co.GetComponent<ControllerBattle>().Damage(dmg);
                }
                break;
            case 2:
                if (co.gameObject.layer == 9 || co.gameObject.layer == 11)
                {
                    co.GetComponent<Enemy>().Damage(dmg);
                }
                break;
            case 3:
                if (co.gameObject.layer == 9 || co.gameObject.layer == 11)
                {
                    if (co.gameObject.layer == 9)
                    {
                        Game.sav.Damage(dmg);
                        if (Game.sav.hp <= 0) { co.GetComponent<ControllerBattle>().Damage(dmg); }
                    }
                    else { co.GetComponent<Enemy>().Damage(dmg); }
                    
                    GetComponent<BoxCollider2D>().enabled = false;
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                break;
            case 4:
                if (co.gameObject.layer == 9 || co.gameObject.layer == 11)
                {
                    if (co.gameObject.layer == 9)
                    {
                        Game.sav.Damage(dmg);
                        if (Game.sav.hp <= 0) 
                        {
                            co.GetComponent<ControllerBattle>().Move(0);
                            co.GetComponent<ControllerBattle>().lockMove = true;
                            co.GetComponent<ControllerBattle>().anim.SetTrigger("Damage");
                            Game.sav.hp = 500;
                        }
                    }
                    else { co.GetComponent<Enemy>().Damage(dmg); }

                    GetComponent<BoxCollider2D>().enabled = false;
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                break;
            case 5:
                if (co.gameObject.layer == 9)
                {
                    if (Game.sav.hp <= dmg)
                    {
                        co.GetComponent<ControllerBattle>().Move(0);
                        co.GetComponent<ControllerBattle>().lockMove = true;
                        co.GetComponent<ControllerBattle>().anim.SetTrigger("Damage");
                        Game.sav.hp = 500;
                    }
                    co.GetComponent<ControllerBattle>().Damage(dmg);
                }
                break;
        }
    }
    
    public enum TargetType {Enemy, Player, All, Keep, KeepStudy, Study};
}
