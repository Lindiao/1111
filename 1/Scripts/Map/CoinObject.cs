using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObject : MonoBehaviour {
    public int amount = 1;
    public World world;//音效
    public AudioClip moveSound;//音效

    //音效
    void Start()
    {
        world = FindObjectOfType<World>();
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        Game.sav.GainMoney(1);
        GetComponent<Animator>().SetTrigger("Eat");
        Destroy(this);
        world.sound.PlaySE(moveSound);//音效
    }
}
