using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{

    public GameObject[] levels;
   // private float startSpawn = 0.5f, waitSpawn = 3f; //время после которого машинка начнет ехать, время между спавном
    //public GameObject Cam = GetComponent<Camera>();

    private bool onceStop;
    bool onceResponse = true;
    float CameraHeight;
    float CameraWidth;
    public Camera Cam;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
        Cam = gameObject.GetComponent<Camera>();
        CameraHeight = Cam.orthographicSize;
        CameraWidth = CameraHeight * Screen.width / Screen.height;
        canvas = GameObject.Find("Canvas");

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       
        if (collision.tag == "Defense" && onceResponse == true)
        {
            Debug.Log(collision.name);
                int levelIndex;
                levelIndex = Random.Range(0, levels.Length);

                GameObject levelInst = Instantiate(levels[levelIndex], new Vector2(0f,980f),
    Quaternion.identity);
            levelInst.transform.SetParent(canvas.transform, false);
            onceResponse = false;
               // Debug.Log(levels[levelIndex].name);
            Destroy(gameObject);
        }
    }


}
