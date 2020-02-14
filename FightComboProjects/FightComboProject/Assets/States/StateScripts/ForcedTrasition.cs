using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
	[CreateAssetMenu(fileName = "New State", menuName = "comboProject/AbilityData/ForcedTransition")]
	public class ForcedTransition : StateData
	{
		[Range(0.01f, 1f)]
		public float TransitionTiming;

		public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
		{

		}

		public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
		{
			MovementManager CharController = characterStateBase.GetMovementManager(animator);

            if (stateInfo.normalizedTime >= TransitionTiming)
            {
                animator.SetBool(TransitionParameter.ForcedTransition.ToString(), true);
            }


        }

		public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
		{
            animator.SetBool(TransitionParameter.ForcedTransition.ToString(), false);
        }
	}

}