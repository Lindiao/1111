using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : Door {
    public GameObject btns;

    public override void Update() {
        base.Update();
        if (Input.GetKeyDown(KeyCode.A) && canOpen) {
            btns.SetActive(true);
        }

    }
}
