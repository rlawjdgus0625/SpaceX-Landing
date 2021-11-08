using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketController : MonoBehaviour
{
    Rigidbody rb;
    float throst = 5.0f;
    float horThrost = 0.2f;
    float yPos = 1.7f, xPos = 1.2f;
    void Move() {
        if(Input.GetKey(KeyCode.Space)) {
            rb.AddForce(transform.up*throst);
        }
        if(Input.GetKey(KeyCode.W)) {
            rb.AddForceAtPosition(transform.forward*horThrost, transform.position+new Vector3(xPos, yPos, 0));
        }
        if(Input.GetKey(KeyCode.A)) {
            rb.AddForceAtPosition(-(transform.right)*horThrost, transform.position+new Vector3(0, yPos, -xPos));
        }
        if(Input.GetKey(KeyCode.S)) {
            rb.AddForceAtPosition(-(transform.forward)*horThrost, transform.position+new Vector3(0, yPos, xPos));
        }
        if(Input.GetKey(KeyCode.D)) {
            rb.AddForceAtPosition(transform.right*horThrost, transform.position+new Vector3(-xPos, yPos, 0));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
