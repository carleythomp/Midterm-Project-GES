using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    [SerializeField] float rotateSpeed = 3.0f;
    CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        cc.SimpleMove(forward * curSpeed);

    }
}
