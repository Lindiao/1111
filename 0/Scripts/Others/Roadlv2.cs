using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roadlv2 : MonoBehaviour {
    public float force = 1000;
    void OnCollisionEnter2D(Collision2D co)
    {
        if(co.gameObject.tag == "Player" && co.contacts[0].normal == -Vector2.up)
        {
            co.rigidbody.AddForce(-co.contacts[0].normal * force);
        }
    }
}
