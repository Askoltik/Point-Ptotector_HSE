using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update

    void Start()
    {
        if (this.enabled)
        {
            Time.timeScale = 0;
        }
  
    }

    // Update is called once per frame
    public void DisableControl()
        {
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    public void EnableControl()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }
    void Update()
    {

    } 
}

