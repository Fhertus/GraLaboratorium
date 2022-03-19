using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sk : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement;
    public float speed = 2.5f;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movement.y = 1f;
            }

        }
        else { movement.y -= 0.01f; }

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        controller.Move(movement * Time.fixedDeltaTime * speed);


    }
}
