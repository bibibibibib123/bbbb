using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public float Speed = 1;
    public float RotationSpeed = 1;
    public Rigidbody rb;
    private Vector3 dirmove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0,0,Input.GetAxis("Horizontal")) * RotationSpeed * Time.fixedDeltaTime);
        dirmove = transform.up * Speed * Input.GetAxis("Vertical");
        move(dirmove,deltaRotation);
        
    }

    void move(Vector3 dir,Quaternion deltaRotation){
        if (dir != Vector3.zero){
            rb.MoveRotation(rb.rotation * deltaRotation);
            rb.velocity = dir * Speed;
        }
    }
}
