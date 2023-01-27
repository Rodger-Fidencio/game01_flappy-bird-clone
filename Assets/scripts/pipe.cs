using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private CapsuleCollider2D capsuleCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        Destroy(this.gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
