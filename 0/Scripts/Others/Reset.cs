using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    internal ControllerBattle cb;

    void Awake()
    {
        cb = FindObjectOfType<ControllerBattle>();
    }
    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.tag == "Player" && co.contacts[0].normal == -Vector2.up)
        {
            cb.Move(0);
            cb.lockMove = true;
            cb.anim.SetTrigger("Die");
            cb.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Reload());
        }
    }

    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(3);
        Game.screen().FadeAndGo(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        Game.Reset();
    }
}
