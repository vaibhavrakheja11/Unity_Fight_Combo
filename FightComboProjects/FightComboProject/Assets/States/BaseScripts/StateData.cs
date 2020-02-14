using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
   
        // Start is called before the first frame update
        public abstract class StateData : ScriptableObject
        {
        
            
            public abstract void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo);
            public abstract void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo StateInfo);
            public abstract void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo StateInfo);
    }
 }
