using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCapsule : MonoBehaviour
{
    
    [SerializeField] float speed = 2f;
    [SerializeField] CharacterController controller;
    
    
    

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        float ver = Input.GetAxis("Vertical") * speed;
        float horiz = Input.GetAxis("Horizontal") * speed;

        Vector3 move = transform.right * horiz + transform.forward * ver;

        controller.Move(move * speed * Time.deltaTime);
        //start sound elements...might be wrong from here
       
        



    }
}
