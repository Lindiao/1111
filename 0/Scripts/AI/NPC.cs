﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector2 waitTime;
    internal OpenUseObject ouo;
    //int storyID = 0;

    internal bool inView = false; // 是否在視野內
                                  // 元件
    internal Navigation2D nav;
    internal Animator anim;
    internal World world;
    
    void Awake()
    {
        nav = GetComponent<Navigation2D>();
        anim = GetComponent<Animator>();
        ouo = GetComponent<OpenUseObject>();
        world = FindObjectOfType<World>();
        pos1 += transform.position;
        pos2 += transform.position;
    }

    void Start()
    {
        StartCoroutine("Wander");
    }

    void Update()
    {
        Talk();
        StateMachine();
    }

    void Talk()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !Game.pause && inView)
        {
            ouo.enabled = true;//開啟對話框內文字
            world.StartTalk(/*storyID*/);
            Game.player().GetComponent<Controller>().Move(0);
        }
        else if(Input.GetKeyDown(KeyCode.Z) && Game.pause && inView) //關閉對話框內文字
        {
            ouo.on.SetActive(false);
            ouo.enabled = false;
        }
    }

    // 遊蕩
    IEnumerator Wander()
    {
        bool point1 = true;
        nav.MoveTo(pos1);

        while (true)
        {
            if (!nav.moving)
            {
                yield return new WaitForSeconds(Random.Range(waitTime.x, waitTime.y));
                point1 = !point1;
                nav.MoveTo(point1 ? pos1 : pos2);
            }
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
    // 狀態
    void StateMachine()
    {
        anim.SetBool("Move", nav.moving && !Game.pause);
    }

    //========
    // 觸發器
    //========
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        co.GetComponent<Controller>().SpawnButton();
        inView = true;
    }
    public void OnTriggerExit2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        co.GetComponent<Controller>().DestroyButton();
        inView = false;
    }

    //=======
    // Debug
    //=======
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + pos1, 0.2f);
        Gizmos.DrawWireSphere(transform.position + pos2, 0.2f);
    }
}
