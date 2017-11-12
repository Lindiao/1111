using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPosition : MonoBehaviour {
    public GameObject obj;

    void Start()
    {
        transform.position = obj.transform.position;
    }
}
