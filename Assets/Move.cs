using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    CharacterController cC;
    public float Speed;
    public float turnSpeed;

    // Use this for initialization
    void Start()
    {
        cC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertInput = Input.GetAxis("Vertical");
        float horizInput = Input.GetAxis("Horizontal");
        cC.SimpleMove(transform.forward * vertInput * Speed);
        transform.Rotate(Vector3.up * horizInput * turnSpeed);
    }
}
