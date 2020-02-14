using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace comboProject
{
    public class ManualInput : MonoBehaviour
    {
        private MovementManager movementManager;
        // Start is called before the first frame update
        void Awake()
        {
            movementManager = this.gameObject.GetComponent<MovementManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if(VirtualInputManager.Instance.MoveRight)
            {
                movementManager.MoveRight = true;
            }
            else
            {
                movementManager.MoveRight = false;
            }
            if (VirtualInputManager.Instance.MoveLeft)
            {
                movementManager.MoveLeft = true;
            }
            else
            {
                movementManager.MoveLeft = false;
            }
            if (VirtualInputManager.Instance.MoveForward)
            {
                movementManager.MoveForward = true;
            }
            else
            {
                movementManager.MoveForward = false;
            }
            if (VirtualInputManager.Instance.MoveBackward)
            {
                movementManager.MoveBackward = true;
            }
            else
            {
                movementManager.MoveBackward  = false;
            }
            if (VirtualInputManager.Instance.Jump)
            {
                movementManager.Jump = true;
            }
            else
            {
                movementManager.Jump = false;
            }
        }
    }

}