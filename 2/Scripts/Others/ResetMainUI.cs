using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMainUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Game.sav.hp = 600;
        Game.sav.sp = 600;
        Game.sav.money = 0;
	}
}
