using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float respawRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < respawRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position, transform.rotation);
            timer = 0;
        }
        
    }
}
