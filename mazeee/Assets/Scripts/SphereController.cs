using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    public float speed;
    private Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHori = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHori, 0.0f, moveVert);
        rbody.AddForce(movement * speed);
    }
}
