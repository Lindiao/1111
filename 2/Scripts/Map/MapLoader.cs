using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoader : MonoBehaviour 
{
    public string map;

    void Awake()
    {
        SceneManager.LoadScene(map, LoadSceneMode.Additive);
    }
}
