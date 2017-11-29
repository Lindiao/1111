using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHp : MonoBehaviour {
    public int hp;

    void OnTriggerEnter2D(Collider2D co) {
        if (co.tag != "Player") { return; }
        if (Game.sav.hp < 600) {
            Game.sav.hp += hp;
            if (Game.sav.hp > 600) {
                Game.sav.hp = 600;
            }
        }

    }
}
