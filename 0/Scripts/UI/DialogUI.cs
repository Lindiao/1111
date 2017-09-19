using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogUI : MonoBehaviour {
    Animation anim;
    World world;

    void Awake()
    {
        anim = GetComponent<Animation>();
        world = FindObjectOfType<World>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Show(false);
            this.enabled = false;
            StartCoroutine(CallEndTalk());
        }
    }

    public void Show(bool b)
    {
        string Name = "ShowDialog";
        anim[Name].speed = b ? 1 : -1;

        if (!anim.isPlaying)
        {
            anim[Name].normalizedTime = b ? 0 : 1;
        }
        anim.Play();
    }

    IEnumerator CallEndTalk()
    {
        yield return new WaitForSeconds(1f);
        world.EndTalk();
    }
}
