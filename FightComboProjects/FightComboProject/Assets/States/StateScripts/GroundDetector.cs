using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    [CreateAssetMenu(fileName = "New State", menuName = "comboProject/AbilityData/GroundDetector")]
    public class GroundDetector : StateData
    {
        [Range(0.01f,1f)]
        public float checkTime;
        public float Distance = 0.02f;
        public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {

        }

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            MovementManager charControl = characterStateBase.GetMovementManager(animator);
           

            if (stateInfo.normalizedTime >= checkTime)
            {
                if (IsGrounded(charControl))
                {
                    animator.SetBool(TransitionParameter.Grounded.ToString(), true);
                }
                else
                {
                    animator.SetBool(TransitionParameter.Grounded.ToString(), false);
                }
            }

        }

        public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo)
        {

        }

        bool IsGrounded(MovementManager charControl)
        {
            if(charControl.RigidBody.velocity.y > -0.01 && charControl.RigidBody.velocity.y <=0f)
            {
                //Debug.Log("Return true");
                return true;
            }
            
            foreach(GameObject o in charControl.BottomSpheres)
            {
               
            }
            foreach(GameObject o in charControl.BottomSpheres)
            {
                
                Debug.DrawRay(o.transform.position, -Vector3.up * 0.02f, Color.red);
                RaycastHit hit;
                
                if (Physics.Raycast(o.transform.position, -Vector3.up, out hit, Distance))
                {
                   
                    return true;
                }
            }
            return false;
        }

    }

}