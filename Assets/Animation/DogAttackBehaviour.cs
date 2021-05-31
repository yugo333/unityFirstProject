using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//各アニメーションごとにコード分ける

public class DogAttackBehaviour : StateMachineBehaviour
{
    Vector3 currentPosition;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //基本的にはanimator変数に全て格納されてる作りになっているのでanimatorから操作する
        //これで自身のコンポーネントを取得できる
        //animator.GetComponent<Animetor>();

        //初期値を保持させる
        currentPosition = animator.transform.position;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position += new Vector3(0, 0.01f, 0);

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = currentPosition;
    }

    //// OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    //// OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}

}
