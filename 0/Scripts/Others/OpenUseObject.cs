using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUseObject : MonoBehaviour {
    public GameObject on;
    
    void Update()
    {
        on.SetActive(true);
    }
}
