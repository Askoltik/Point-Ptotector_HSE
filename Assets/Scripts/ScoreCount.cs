using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour{

    private IEnumerator coroutine;
    public Text ScoreManager;
    int sum = 0;
    float speed = 0.4f;
    void Start()
    {

        coroutine = WaitAndPrint(speed);
        StartCoroutine(coroutine);

    }

    private void Update()
    {

    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            sum++;
            ScoreManager.text = Convert.ToString(sum);
            if (waitTime > 0.06f) { waitTime = waitTime - 0.002f; }
            else { waitTime = 0.06f; }
            
            
           
        }
    }
}


