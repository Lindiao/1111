﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MainUI : MonoBehaviour {
    //public Transform hearts;
    //public Sprite[] heartImage;
    public RectTransform sp;
    public RectTransform hp;//test
    public Text coinText;
    int coin = 0;

    /*void Awake()
    {
        DrawMaxHP();
    }*/

    void Update()
    {
        DrawSP();
        DrawCoin();
        DrawHP();
    }
    /*
    void DrawMaxHP()
    {
        for (int i = 1; i < Game.sav.maxHp; i++)
        {
            Transform h = Instantiate(hearts.GetChild(0));
            h.SetParent(hearts, false);
            h.name = "h" + (i + 1);
        }
        DrawHP();
    }

    void DrawHP()
    {
        float hp = Game.sav.hp;
        foreach (Image img in hearts.GetComponentsInChildren<Image>())
        {
            img.sprite = heartImage[0];
        }

        for (int i = 1; i <= hp; i++)
        {
            hearts.GetChild(i - 1).GetComponent<Image>().sprite = heartImage[2];
        }

        if (hp > Mathf.Floor(hp))
        {
            hearts.GetChild((int)Mathf.Floor(hp)).GetComponent<Image>().sprite = heartImage[1];
        }
    }*/

    void DrawHP()
    {
        float h = Game.sav.hp;
        hp.sizeDelta = new Vector2(Mathf.Lerp(hp.sizeDelta.x, h, 0.12f), hp.sizeDelta.y);
    }

    void DrawSP()
    {
        float s = Game.sav.sp;
        sp.sizeDelta = new Vector2(Mathf.Lerp(sp.sizeDelta.x, s, 0.12f), sp.sizeDelta.y);
    }

    void DrawCoin()
    {
        if (Game.sav.money > coin)
        {
            coinText.GetComponentInParent<Animation>().Play();
        }
        coin = Game.sav.money;
        coinText.text = "x " + Game.sav.money;
    }
}
