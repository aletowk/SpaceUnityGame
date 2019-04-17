using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject target;
    public float desiredDistance = 0f;
    public float sensitivity = 15;

    float pitch = 0;
    float yaw = 0;
    float roll = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position - desiredDistance * transform.forward + Vector3.up * 1f;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            pitch -= sensitivity *  Input.GetAxis("Mouse Y");
            yaw += sensitivity * Input.GetAxis("Mouse X");
            transform.localEulerAngles = new Vector3(pitch, yaw, roll);
        }
    }
}
