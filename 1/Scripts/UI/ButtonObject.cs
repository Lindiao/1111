using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour {
    Transform pl;

    void Awake()
    {
        pl = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = pl.position + new Vector3(0, 1.8f, 0);
    }
}
