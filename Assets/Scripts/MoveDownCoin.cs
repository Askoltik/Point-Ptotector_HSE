using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveDownCoin : MonoBehaviour
{

    public float speedOfFall = 2f;
    public Rigidbody2D rb;
    private bool touched = false;
    public float thrust = 10.0f;


    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;


    }

    // Update is called once per frame
    void Update()
    {
        if (!touched)
        {
            this.transform.position = new Vector2(transform.position.x, transform.position.y - speedOfFall * Time.deltaTime);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }

    }


}
