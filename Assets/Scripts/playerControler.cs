using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{

    CharacterController cc;
    public float moveSpeed = 4f;
    float gravity = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, 0, z).normalized;
        Vector3 velocity = direction * moveSpeed * Time.deltaTime;

        if(cc.isGrounded)
        {
            gravity = 0f;
        }else
        {
            gravity += 0.25f;
            gravity = Mathf.Clamp(gravity, 1f, 20f);
        }

        Vector3 gravityVector = -Vector3.up * gravity * Time.deltaTime;


        cc.Move(velocity + gravityVector);

        
        if( velocity.magnitude > 0)
        {
            float yAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.localEulerAngles = new Vector3(0, yAngle, 0);
        }
            
    }

}
