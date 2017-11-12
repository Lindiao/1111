using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOver : MonoBehaviour {
    public Transform hand;
    public Transform[] buttons;
    public float[] xOffset;
    public World world;
    public AudioClip moveSound;
    public AudioClip okSound;
    int id = 0;

    // Use this for initialization
    void Start()
    {
        world = FindObjectOfType<World>();
        id = 0;
        UpdatePosition();
    }

    // Update is called once per frame
    void Update()
    {
        // 選單選擇
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            id++;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            id--;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        // 確定
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (id)
            {
                // yes
                case 0:
                    Game.screen().FadeAndGo("Level1");
                    this.enabled = false;
                    break;
                // no
                case 1:
                    Game.screen().FadeAndGo("LevelTeaching");
                    this.enabled = false;
                    break;
            }
            world.sound.PlaySE(okSound);
        }
    }

    void UpdatePosition()
    {
        Vector3 pos = hand.position;
        pos.y = buttons[id].position.y - 0.25f;
        pos.x = xOffset[id];
        hand.position = pos;
    }
}
