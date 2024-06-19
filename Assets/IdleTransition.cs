using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleTransition : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       PlayerController.instance.playerState = PlayerState.Idle;
    }
}
