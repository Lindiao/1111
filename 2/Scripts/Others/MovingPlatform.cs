using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

    float alpha = 0;
    public float speed = 0.05f;
    public float distance_x = 10f;
    public float distance_y = 10f;

    internal bool inView = false; // 是否在視野內
                                  // 元件

    void Update() {
        Vector3 pos = transform.localPosition;
        if(distance_x == 0)
        {
            transform.localPosition = new Vector3(0, Mathf.PingPong(alpha, distance_y), 0);
        }else if(distance_y == 0)
        {
            transform.localPosition = new Vector3(Mathf.PingPong(alpha, distance_x),0 , 0);
        }else
        {
            transform.localPosition = new Vector3(Mathf.PingPong(alpha, distance_x), Mathf.PingPong(alpha, distance_y), 0);
        }
        alpha+=speed;
    }

    void OnCollisionEnter2D(Collision2D co) {
        if (co.gameObject.layer == 9 && co.contacts[0].normal == -Vector2.up) {
            var target = co.gameObject.transform;
            target.SetParent(this.transform);
        }
    }

    void OnCollisionExit2D(Collision2D co) {
        if (co.gameObject.layer==9) {
            var target = co.gameObject.transform;
            var original = target.GetComponent<TransformState>().OriginalParent;
            target.SetParent(original);
        }
    }

    //========
    // 觸發器
    //========
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        co.GetComponent<Controller>().NoAfkButton();
        co.GetComponent<ControllerBattle>().NoAfk = true;
        inView = true;
    }
    public void OnTriggerExit2D(Collider2D co)
    {
        if (co.tag != "Player") { return; }
        co.GetComponent<Controller>().DestroyButton();
        co.GetComponent<ControllerBattle>().NoAfk = false;
        inView = false;
    }
}
