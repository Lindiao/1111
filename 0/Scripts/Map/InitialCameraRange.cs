using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialCameraRange : MonoBehaviour {
    public Vector3 center;
    public Vector3 size;

    void Awake()
    {
        GameObject.Find("CamRange").GetComponent<BoxCollider>().center = center;
        GameObject.Find("CamRange").GetComponent<BoxCollider>().size = size;
    }

    void Start()
    {
        GameObject.Find("CamRange").transform.position = transform.position;
    }
}
