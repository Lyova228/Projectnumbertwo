using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed;
    public float xrange;
    public float zrange;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        /// X
        if (transform.position.x > xrange) {
            transform.position = new Vector3(xrange,transform.position.y, transform.position.z);
        }
         if (transform.position.x < -xrange) {
            transform.position = new Vector3(-xrange,transform.position.y, transform.position.z);
        }
        /// Z
        if (transform.position.z > zrange) {
            transform.position = new Vector3(transform.position.x,transform.position.y, zrange);
        }
         if (transform.position.z < -zrange) {
            transform.position = new Vector3(transform.position.x,transform.position.y, -zrange);
        }
    }
}
