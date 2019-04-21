using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float planetRotationSpeed = 0.01f;
    public float planetOrbitalSpeed = 3;
    private float orbitDistance;
    public GameObject parentSun;
    // Start is called before the first frame update
    void Start()
    {
        orbitDistance = Mathf.Abs(parentSun.transform.position.x - transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parentSun.transform.position + (transform.position - parentSun.transform.position).normalized * orbitDistance;
        transform.RotateAround(parentSun.transform.position, Vector3.up, -planetOrbitalSpeed * Time.deltaTime);
    }
}
