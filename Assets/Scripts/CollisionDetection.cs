using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionDetection : MonoBehaviour
{
    public GameObject menu, score, score_record;
    string score_text, score_record_text;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            var A = Convert.ToString(PlayerPrefs.GetString("Score"));
            var B = score.GetComponent<Text>().text;
           if (Convert.ToInt32(A) < Convert.ToInt32(B)) 
               {
                PlayerPrefs.SetString("Score", Convert.ToString(score.GetComponent<Text>().text));
                PlayerPrefs.Save();


             }

            score_record.GetComponent<Text>().text = PlayerPrefs.GetString("Score");
            Debug.Log(A);
            Debug.Log(B);
            Time.timeScale = 0;
            menu.SetActive(true);

        }
    }
}
