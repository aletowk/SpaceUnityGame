using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject target;
    public float desiredDistance = 0f;
    public float verticalOffset = 0f;

    void Start()
    {
        transform.position = target.transform.position - new Vector3(0, 0, 0);    
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position - desiredDistance * transform.forward + Vector3.up * verticalOffset;
        transform.rotation = target.transform.rotation;
    }
}