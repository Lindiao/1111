using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGift : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        Game.gift++;
        Destroy(gameObject);
    }
}
