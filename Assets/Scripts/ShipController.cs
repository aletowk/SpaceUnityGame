using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    public float shipSpeed = 2f;
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");
        float roll = Input.GetAxis("Roll");
        
        transform.Rotate(new Vector3(pitch,yaw,-roll));



        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = new Vector3(pitch, yaw, roll).normalized;
            cc.Move(transform.rotation*Vector3.forward * shipSpeed * Time.deltaTime); 
        }
    }
}
