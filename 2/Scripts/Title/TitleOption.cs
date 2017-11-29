using System.Collections;
using UnityEngine;

public class TitleOption : MonoBehaviour {

    public Transform hand;
    public Transform[] buttons;
    public float[] xOffset;
    public World world;
    public AudioClip moveSound;
    public AudioClip okSound;
    public AudioClip passwordSound;
    int id = 0;
    int password = 0;
    int num = 0;

    // Use this for initialization
    void Start () {
        world = FindObjectOfType<World>();
        id = 0;
        UpdatePosition();
    }
	
	// Update is called once per frame
	void Update () {
        // 選單選擇
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            password = 0;
            num = 0;
            id--;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            password = 0;
            num = 0;
            id++;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        // 確定
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (id)
            {
                // new
                case 0:
                    if (password == 9)
                    {
                        Game.screen().FadeAndGo("Hard-1");
                    }else
                    {
                        Game.screen().FadeAndGo("JumpOver");
                    }
                    this.enabled = false;
                    break;
                // exit
                case 1:
                    Application.Quit();
                    break;
            }
            world.sound.PlaySE(okSound);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            num = 0;
            world.sound.PlaySE(moveSound);
            if (password != 0 && password != 3 && password != 4) { password = 0; }
            password++;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            num = 0;
            world.sound.PlaySE(moveSound);
            if (password != 1 && password != 2 && password != 5) { password = 0; }
            password++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            num = 0;
            world.sound.PlaySE(moveSound);
            if (password != 6 && password != 7) { password = 0; }
            password++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            num = 0;
            world.sound.PlaySE(moveSound);
            if (password != 8) { password = 0; }
            password++;
        }
        if(password == 9)
        {
            if(num == 0) { world.sound.PlaySE(passwordSound);num++; }
        }
    }

    void UpdatePosition()
    {
        Vector3 pos = hand.position;
        pos.y = buttons[id].position.y - 0.22f;
        pos.x = xOffset[id];
        hand.position = pos;
    }
}
