using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterClose : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.layer != 9) { return; }
        Destroy(gameObject);
    }
}
