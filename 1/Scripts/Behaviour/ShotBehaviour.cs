using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehaviour : StateMachineBehaviour
{

    override public void OnStateUpdate(Animator anim, AnimatorStateInfo info, int id)
    {
        anim.GetComponentInParent<Rigidbody2D>().drag = 20;
    }
    override public void OnStateExit(Animator anim, AnimatorStateInfo info, int id)
    {
        anim.GetComponentInParent<Rigidbody2D>().drag = 0;
    }
}
