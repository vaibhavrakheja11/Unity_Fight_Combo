using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    [CreateAssetMenu(fileName = "New State", menuName = "comboProject/AbilityData/JumpLanding")]
    public class JumpLanding : StateData
    {
        [Range(0.01f, 1f)]
        public float TransitionTiming;

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {
            animator.SetBool(TransitionParameter.Jump.ToString(), false);
        }

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            


        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {
            // animator.SetBool(TransitionParameter.ForcedTransition.ToString(), false);
        }
    }

}