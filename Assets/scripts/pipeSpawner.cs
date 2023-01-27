using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float respawRate = 3;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpaw();
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
            pipeSpaw();
        }
        
    }

    void pipeSpaw()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
        timer = 0;
        
    }

}
