using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;    
    public float xMin, xMax, yMin, yMax, zMin, zMax;
    public int SpawnAmount = 0;

    private float xPos, zPos, yPos;

    void Start()
    {
        for (int i = 0; i < SpawnAmount; i++)
        {
            
            xPos = Random.Range(xMin, xMax);
            yPos = Random.Range(yMin, yMax);
            zPos = Random.Range(zMin, zMax);
            Instantiate(spawnee, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        }
    }

}
