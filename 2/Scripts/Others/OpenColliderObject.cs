using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenColliderObject : MonoBehaviour {
    public GameObject on;
    int num = 0;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (num > 0) return;
        if (co.tag != "Player") return;
        on.SetActive(true);
        num++;
    }
}
