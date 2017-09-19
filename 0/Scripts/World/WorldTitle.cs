using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class WorldTitle : World {
    public GameObject btns;
    public GameObject anyKeyText;

    void Update()
    {
        // 按下任意鍵
        if (Input.anyKey)
        {
            btns.SetActive(true);
            anyKeyText.SetActive(false);
        }
    }
}
