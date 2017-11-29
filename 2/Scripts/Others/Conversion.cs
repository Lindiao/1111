using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversion : MonoBehaviour {
    public int num;
    internal Animator anim;
    internal OpenUseObject ouo;

    void Awake()
    {
        anim = GetComponent<Animator>();
        ouo = GetComponent<OpenUseObject>();
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (Game.sav.money < num) return;
        if (co.tag != "Player") return;
        ouo.enabled = true;
        anim.SetTrigger("Open");
        anim.SetBool("Go", true);
    }

    public void OnTriggerExit2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        ouo.enabled = false;
        ouo.on.SetActive(false);
        anim.SetBool("Go",false);
    }
}
