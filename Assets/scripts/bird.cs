using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    private GameLogic manager;

    Rigidbody2D rb;
    [SerializeField] int jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = GameObject.Find("Game Manager").GetComponent<GameLogic>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.gameOver();
    }
}
