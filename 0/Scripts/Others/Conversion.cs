using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversion : MonoBehaviour {
    internal Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") return;
        anim.SetTrigger("Open");
        anim.SetBool("Go", true);
    }

    public void OnTriggerExit2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        anim.SetBool("Go",false);
    }
}
