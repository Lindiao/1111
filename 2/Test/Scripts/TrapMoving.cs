using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMoving : MonoBehaviour {
    internal Animation anim;

    public float speed = 0.05f;
    public float distance_x1 = 0;
    public float distance_x2 = 10;
    public float distance_y = 0;

    public void Awake() {
        anim = GetComponentInChildren<Animation>();
    }

    void Update() {
        Vector3 pos = transform.localPosition;
        transform.localPosition = new Vector3(Mathf.PingPong(distance_x1, distance_x2), distance_y, 0);
        distance_x1 += speed;
    }
}
