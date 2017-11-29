using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public bool canOpen = false;  // 可不可以開啟 

    public void HideCollider() {
        Collider2D[] colliders = GetComponentsInChildren<Collider2D>();

        foreach (Collider2D co in colliders) {
            co.enabled = false;
        }
    }

    public virtual void Update() {
        if (Input.GetKeyDown(KeyCode.A) && canOpen) {
            GetComponent<Animation>().Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        // 判斷玩家
        if (other.tag == "Player") {
            other.GetComponent<Controller>().SpawnButton();
            canOpen = true;
        }
}

    void OnTriggerExit2D(Collider2D other) {
        // 判斷玩家
        if (other.tag == "Player") {
            other.GetComponent<Controller>().DestroyButton();
            canOpen = false;
        }
    }
}