using System.Collections;
using UnityEngine;

public class TitleOption : MonoBehaviour {

    public Transform hand;
    public Transform[] buttons;
    public float[] xOffset;
    public World world;
    public AudioClip moveSound;
    public AudioClip okSound;
    int id = 0;

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
            id--;
            id = Mathf.Clamp(id, 0, 1);
            world.sound.PlaySE(moveSound);
            UpdatePosition();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
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
                    Game.screen().FadeAndGo("JumpOver");
                    this.enabled = false;
                    break;
                // exit
                case 1:
                    Application.Quit();
                    break;
            }
            world.sound.PlaySE(okSound);
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
