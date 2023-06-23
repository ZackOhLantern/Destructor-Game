using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefabVar;
    public GameObject spherePrefabVar;
    public  float lifeTime;


    // Start is called before the first frame update
    void Start()
    {
        //GameObject SpawnedCube = Instantiate(cubePrefabVar);
        //Destroy(SpawnedCube, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        int cubeOrSphere = Random.Range(0, 10); ;
        if (cubeOrSphere % 10 == 0)
        {
            GameObject SpawnedCube = Instantiate(cubePrefabVar);
            SpawnedCube.GetComponent<Renderer>().material.color = new Color((Random.Range(0f, 1.0f)), (Random.Range(0f, 1.0f)), (Random.Range(0f, 1.0f)));
            Destroy(SpawnedCube, lifeTime);
        }
        else if (cubeOrSphere % 10 == 1){
            GameObject SpawnedSphere = Instantiate(spherePrefabVar);
            SpawnedSphere.GetComponent<Renderer>().material.color = new Color((Random.Range(1.0f, 2.0f)), (Random.Range(1.0f, 2.0f)), (Random.Range(1.0f, 2.0f)));
            Destroy(SpawnedSphere, lifeTime);
        }
    }
}
