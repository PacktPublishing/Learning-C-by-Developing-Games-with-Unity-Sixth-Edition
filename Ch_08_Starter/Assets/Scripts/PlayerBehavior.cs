using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Time for action - player locomotion
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float VInput;
    private float HInput;

    // Time for action - accessing the RigidBody component
    private Rigidbody _rb;

    void Start()
    { 
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        VInput = Input.GetAxis("Vertical") * MoveSpeed;
        HInput = Input.GetAxis("Horizontal") * RotateSpeed;

        /*
        this.transform.Translate(Vector3.forward * VInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * HInput * Time.deltaTime);
        */
    }

    // Time for action - moving the RigidBody component
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * HInput;
        Quaternion angleRot = Quaternion.Euler(rotation *Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * VInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
