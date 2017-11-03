using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLevel : MonoBehaviour {
    public int num;
    public GameObject wall;

	// Update is called once per frame
	void Update () 
    {
        if (Game.sav.money < num) return;
        wall.SetActive(false);
    }
}
