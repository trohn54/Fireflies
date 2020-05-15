using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly : MonoBehaviour
{
    private Vector3 position     = new Vector3(0, 0, 0);
    private Vector3 velocity     = new Vector3(0, 0, 0);
    private Vector3 acceleration = new Vector3(0, 0, 0);

    //From what I've observed, fireflies move slower vertically
    public float range = 0.1f;

    private GameObject fly;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SmoothRandom", Random.Range(0, 0.5f), 0.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        this.transform.position += velocity;
    }

    void SmoothRandom()
    {
        Vector3 newAccel = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));

        acceleration = newAccel;
        velocity += acceleration *Time.deltaTime;
    }
}
