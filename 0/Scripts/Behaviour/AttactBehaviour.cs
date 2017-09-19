using System.Collections;
using UnityEngine;

public class AttactBehaviour : StateMachineBehaviour
{  
    public float transhold = 1f;
    public int order = 0;

    override public void OnStateUpdate(Animator anim, AnimatorStateInfo info, int id)
    {
        if (info.normalizedTime <= transhold)
        {
            anim.SetInteger("Attack", order);
        }
    }

    override public void OnStateExit(Animator anim, AnimatorStateInfo info, int id)
    {
        anim.SetInteger("Attack", 0);
    }
}
