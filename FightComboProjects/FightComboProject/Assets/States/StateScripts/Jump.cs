using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    [CreateAssetMenu(fileName = "New State", menuName = "comboProject/AbilityData/Jump")]
    public class Jump : StateData
    { 

        public float jumpForce = 3f;

        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {
            characterState.GetMovementManager(animator).RigidBody.AddForce(Vector3.up * jumpForce);
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