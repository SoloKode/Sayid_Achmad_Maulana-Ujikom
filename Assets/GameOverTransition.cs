using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTransition : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        PlayerController.instance.playerState = PlayerState.Finish;
    }
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerController.instance.playerState = PlayerState.Finish;
    }
    override public void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        PlayerController.instance.playerState = PlayerState.Finish;
    }
}
