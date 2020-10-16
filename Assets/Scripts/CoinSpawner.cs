using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    float CameraHeight;
    float CameraWidth;
    private Vector2 position;
    public GameObject Coin;
    private IEnumerator coroutine;
    float speed = 10f;
    public float speedOfFall = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Camera Cam = GetComponent<Camera>();
        CameraHeight = Cam.orthographicSize;
        CameraWidth = CameraHeight * Screen.width / Screen.height;
        coroutine = WaitAndSpawn(speed);
        StartCoroutine(coroutine);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            position = new Vector2(Random.Range(-CameraWidth + (CameraWidth * 0.15f), CameraWidth - (CameraWidth * 0.15f)), Random.Range(CameraHeight+6f, CameraHeight+5f));
            Instantiate(Coin, position, transform.rotation);

        }
    }
}
