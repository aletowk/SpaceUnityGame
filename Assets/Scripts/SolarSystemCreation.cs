using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemCreation : MonoBehaviour
{

    //public GameObject moonGO;
    //public GameObject planetGO;
    // Attributes
    public new string name = "Alpha Centauri";
    public int planetNumber = 3;

    List<GameObject> planetGOList;
    List<Vector3> planetPosition;
    GameObject tmpGO;

    public float minimalMoonDistance = 7f;
    public float maximalMoonDistance = 15f;
    // Start is called before the first frame update
    void Start()
    {
        InitSolarSystem();
        PrintSolarSystemInfo();
        //GameObject planetGO = (GameObject)Resources.Load("Prefabs/GreenPlanetManager", typeof(GameObject));
        //GameObject moonGO = (GameObject)Resources.Load("Prefabs/MoonManager", typeof(GameObject));
        //Instantiate(planetGO, Vector3.zero, Quaternion.identity);

        //Vector3 moonPosition = new Vector3(planetGO.transform.position.x + Mathf.Clamp(Random.Range(0, 100), minimalMoonDistance, maximalMoonDistance), planetGO.transform.position.y, planetGO.transform.position.z);
        //Instantiate(moonGO, moonPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void InitSolarSystem()
    {
        int i = 0;

        planetGOList = new List<GameObject>();
        planetPosition = new List<Vector3>();

        tmpGO = (GameObject)Resources.Load("Prefabs/GreenPlanetManager", typeof(GameObject));
        planetPosition.Add(Vector3.zero);
        planetGOList.Add(tmpGO);

        tmpGO = (GameObject)Resources.Load("Prefabs/MoonManager", typeof(GameObject));
        planetGOList.Add(tmpGO);
        Vector3 moonPosition = new Vector3(planetGOList[0].transform.position.x + Mathf.Clamp(Random.Range(0, 100), minimalMoonDistance, maximalMoonDistance), planetGOList[0].transform.position.y, planetGOList[0].transform.position.z);
        planetPosition.Add(moonPosition);

        for(i = 0 ; i < planetGOList.Count ; i++)
        {
            Instantiate(planetGOList[i], planetPosition[i], Quaternion.identity);
        }
    }


    void PrintSolarSystemInfo()
    {
        int i = 0;
        for(i = 0 ; i < planetGOList.Count; i++)
        {
            Debug.Log(planetGOList[i]);
            Debug.Log(planetPosition[i]);
        }   
    }
}
