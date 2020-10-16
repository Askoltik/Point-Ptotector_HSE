using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownForStaticObjects : MonoBehaviour
{

    public float speedOfFall = 2f;
    private bool touched = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!touched)
        {
            this.transform.position = new Vector2(transform.position.x, transform.position.y - speedOfFall * Time.deltaTime);
        }


    }


}
