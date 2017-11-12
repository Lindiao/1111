using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game {

    public static SaveData sav = new SaveData();
    public static bool pause = false;

    public static void Reset()
    {
        sav = new SaveData();
    }

    // 取得screen
    public static ScreenUI screen()
    {
        return UnityEngine.Object.FindObjectOfType<ScreenUI>();
    }
    // 快速取得角色
    public static Transform player()
    {
        return GameObject.FindWithTag("Player").transform;
    }

    public class SaveData
    {
        public float maxHp = 600f;
        public float hp = 600f;
        public float maxSp = 600f;
        public float sp = 600f;
        public int money = 0;
        public float skillCost = 100f;
        public float regSpeed_SP = 15f;
        public float regSpeed_HP = 1.5f;//test
        public float ammoCost = 5f;

        public void GainMoney(int i)
        {
            money = (int)Mathf.Clamp(money + i, 0, 999f);
        }

        public void CostSP(float s)
        {
            sp = Mathf.Clamp(sp - s, 0, maxSp);
        }

        //test
        public void CostHP(float h)
        {
            hp = Mathf.Clamp(hp - h, 0, maxHp);
        }
        //test

        public void RegenSP(float f)
        {
            CostSP(-regSpeed_SP * f);
        }

        //test
        public void RegenHP(float h)
        {
            CostHP(-regSpeed_HP * h);
        }
        //test

        public bool CanUseSkill()
        {
            return sp >= skillCost;
        }

        public bool HasAmmo()
        {
            return sp >= ammoCost;
        }

        public float Damage(float dmg)
        {
            hp = Mathf.Clamp(hp - dmg, 0, maxHp);
            return hp;
        }
    }
}
