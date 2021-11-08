using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.relativeVelocity.y < -10) {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0, 1);
        } else {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0, 1);
        }
    }

    private void OnCollisionExit(Collision other) {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0, 1);
    }
}
