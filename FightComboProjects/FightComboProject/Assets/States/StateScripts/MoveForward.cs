using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    [CreateAssetMenu(fileName = "New State", menuName = "comboProject/AbilityData/MoveForward")]
    public class MoveForward : StateData
    {
        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {
           
        }

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            MovementManager CharController = characterStateBase.GetMovementManager(animator);

            if (CharController.MoveForward && CharController.MoveBackward)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }
            if (!CharController.MoveForward && !CharController.MoveBackward && !CharController.MoveLeft && !CharController.MoveRight)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (CharController.MoveForward || CharController.MoveLeft || CharController.MoveRight)
            {
                //animator.SetBool(TransitionParameter.Move.ToString(), true);
            }

            if (CharController.MoveLeft)
            {

                //Debug.Log("read A");
                CharController.transform.Translate(Vector3.left * 5f * Time.deltaTime);


            }


            if (CharController.MoveRight)
            {
                //Debug.Log("read A");
                CharController.transform.Translate(Vector3.right * 5f * Time.deltaTime);


            }
            if (CharController.MoveForward)
            {
                CharController.transform.Translate(Vector3.forward * 7f * Time.deltaTime);

            }
            Debug.Log("MoveBackward" + CharController.MoveBackward);
            if (CharController.MoveBackward)
            {
                Debug.Log("Here back");
                CharController.transform.Translate(-Vector3.forward * 4f * Time.deltaTime);
                //animator.SetBool("Move", false);
            }
        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {
            
        }
    }

}