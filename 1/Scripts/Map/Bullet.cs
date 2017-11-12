using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 4;
    public float lifeTime = 1;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.layer != 11) { return; }
        Destroy(gameObject);
    }
}
