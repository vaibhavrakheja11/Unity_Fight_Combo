using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    public class CharacterStateBase : StateMachineBehaviour
    {

        public List<StateData> ListAbilityData = new List<StateData>();


        

        private MovementManager movementManager;
        public MovementManager GetMovementManager(Animator animator)
        {
            if (movementManager == null)
            {
                movementManager = animator.GetComponentInParent<MovementManager>();
            }
             
            return movementManager;
        }
        public void UpdateAll(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo animatorStateInfo)
        {
            foreach(StateData d in ListAbilityData)
            {
                d.UpdateAbility(characterStateBase, animator, animatorStateInfo);
            }

        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this, animator, stateInfo);
        }

        public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.OnEnter(this, animator, animatorStateInfo);
            }
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.OnEnter(this, animator, animatorStateInfo);
            }
        }
    }
}
