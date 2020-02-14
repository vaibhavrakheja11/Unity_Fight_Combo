using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace comboProject
{
    public class KeyboardInput : MonoBehaviour
    {
        
        void Update()
        {
            if(Input.GetKey(KeyCode.D))
            {
                Debug.Log("fed D");
                VirtualInputManager.Instance.MoveRight = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveRight = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("fed A");
                VirtualInputManager.Instance.MoveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeft = false;
            }

            if (Input.GetKey(KeyCode.W))
            {
                VirtualInputManager.Instance.MoveForward = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveForward = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                VirtualInputManager.Instance.MoveBackward = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveBackward = false;
            }

            if(Input.GetKey(KeyCode.Space))
            {
                VirtualInputManager.Instance.Jump = true;
            }
            else
            {
                VirtualInputManager.Instance.Jump = false;
            }

        }
    }
} 

