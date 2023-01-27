using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class midlePipeScript : MonoBehaviour
{

    private logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("SCORE").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
