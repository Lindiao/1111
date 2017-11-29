using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 4f;
    public float lifeTime = 1f;
    public TargetType type = TargetType.Right;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        switch ((int)type)
        {
            case 0:
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                break;
            case 1:
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                break;
            case 2:
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                break;
            case 3:
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                break;
        }
                
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.layer == 11)
        {
            Destroy(gameObject);
        }else if(co.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }

    public enum TargetType { Right, Left, Down, Up };
}
