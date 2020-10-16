using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveDown : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.gravityScale = 0.3f;
        touched = true;
       
        // rb.AddForce(tra.forward  * collision.relativeVelocity, ForceMode2D.Impulse);
      /*  Vector2 dir = transform.position - collision.transform.position;
        dir.Normalize();
        Debug.Log(dir);
        rb.AddForce(-dir * thrust);*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }


}
