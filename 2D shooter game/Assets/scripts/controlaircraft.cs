using UnityEngine;
using System.Collections;

public class controlaircraft : MonoBehaviour
{

    float acceleration = 3;
    Rigidbody thisRigidBody;

    // Use this for initialization
    void Start()
    {
        thisRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log( Vector3.forward);
        Debug.Log(Input.GetAxis("Horizontal"));
        thisRigidBody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * acceleration);
        thisRigidBody.AddForce(Vector3.up * Input.GetAxis("Vertical") * acceleration);
        //     GetComponent<Rigidbody>().AddForce( Vector3.right * Input.GetAxis("Horizontal")*acceleration);
    }
}