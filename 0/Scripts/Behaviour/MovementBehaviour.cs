using UnityEngine;
using System.Collections;

public class MovementBehaviour : StateMachineBehaviour
{
    override public void OnStateEnter(Animator anim, AnimatorStateInfo info, int id)
    {
        anim.ResetTrigger("Skill");
        anim.SetBool("Shot", false);
        anim.GetComponentInParent<Controller>().lockMove = false ;
    }

    override public void OnStateUpdate(Animator anim, AnimatorStateInfo info, int id)
    {
        Game.sav.RegenSP(Time.deltaTime);
        anim.GetComponentInParent<Controller>().lockMove = false;
    }
}

