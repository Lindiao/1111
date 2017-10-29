using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string map;
    public Vector3 position;

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") return;
        SceneManager.LoadScene(map, LoadSceneMode.Additive);//LoadSceneMode.single
        SceneManager.UnloadSceneAsync(gameObject.scene);
        GameObject.Find("Battle_Cat").transform.position = position;
    }

    void Update()
    {
        int num = 0;
        while (num == 7)
        {
            num = Random.Range(1, 14);
        }
    }
}