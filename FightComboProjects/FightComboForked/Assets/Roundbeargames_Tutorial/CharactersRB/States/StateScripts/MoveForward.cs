using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    [CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/MoveForward")]
    public class MoveForward : StateData
    {
        public float Speed;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);
            Debug.Log(control.MoveForward);
            if (control.MoveRight && control.MoveLeft && control.MoveForward)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }

            if (!control.MoveRight && !control.MoveLeft && !control.MoveForward)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                return;
            }
            if (control.MoveForward)
            {

                control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                //control.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // change direction forward
            }
            if (control.MoveRight)
            {
                //Debug.Log(control.MoveForward);
                control.transform.Translate(Vector3.right * Speed * Time.deltaTime);
                //control.transform.rotation = Quaternion.Euler(0f, 0f, 0f); // change direction forward
            }
            


            if (control.MoveLeft)
            {
                control.transform.Translate(Vector3.left * Speed * Time.deltaTime);
                //control.transform.rotation = Quaternion.Euler(0f, 180f, 0f); // change direction backward
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }
}