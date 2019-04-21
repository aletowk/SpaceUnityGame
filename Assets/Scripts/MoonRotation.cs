using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{

    public GameObject parentPlanet;
    public GameObject parentSun;
    public float moonRotationSpeed;
    private float moonOrbitalDistance;

    // Start is called before the first frame update
    void Start()
    {
        moonOrbitalDistance = Mathf.Abs(parentPlanet.transform.position.x - transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parentPlanet.transform.position + (transform.position - parentPlanet.transform.position).normalized * moonOrbitalDistance;
        transform.RotateAround(parentPlanet.transform.position, Vector3.up, - moonRotationSpeed * Time.deltaTime);
    }
}
