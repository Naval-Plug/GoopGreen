using log4net.Util;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using UnityEngine;
using UnityEngine.
namespace Assembly_CSharp_Editor
{
    class PlayerMovement : MonoBehavior
    {

        public float moveSpeed;

        public Transform orientation;

        float horizontalInput;
        float vertialInput;

        Vector3 moveDirection;

        Rigidbody rb;

        private void start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
        }

        private void Update()
        {
            MyInput();
        }

        private void myInput
        {
            horizontalInput = Input.GetAxisRaw("Horizontal");
            verticalInput = Input.GetAxisRaw("Vertical");
        }

    private void MovePlayer()
        {
            move
        }


    }
}