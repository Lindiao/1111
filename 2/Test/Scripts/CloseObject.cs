using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseObject : MonoBehaviour {

    public GameObject on;
    internal Enemy enemy;

    void Awake() {
        enemy = GetComponent<Enemy>();
    }

    void Update() {
        if (enemy.hp <= 0) {
            on.SetActive(false);
        }
    }
}
