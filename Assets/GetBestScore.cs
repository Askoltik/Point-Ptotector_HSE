using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetBestScore : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetString("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
