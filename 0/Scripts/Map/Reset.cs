using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D co)
    {
        if (co.gameObject.tag == "Player" && co.contacts[0].normal == -Vector2.up)
        {
            // Die
            gameObject.layer = 0;
            this.enabled = false;
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
