using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{

    // Update is called once per frame

    Vector2 direction;
    Vector3 mousePosition;
    Rigidbody2D rb;
    public float moveSpeed = 100f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
            
        }
        else {
            rb.velocity = Vector2.zero;
            
        }
      /*  Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
