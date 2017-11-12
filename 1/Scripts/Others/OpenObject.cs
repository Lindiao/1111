using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenObject : MonoBehaviour {
    public GameObject on;
    internal Enemy enemy;

    void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    void Update()
    {
        if (enemy.hp <= 0)
        {
            on.SetActive(true);
        }
    }
}
