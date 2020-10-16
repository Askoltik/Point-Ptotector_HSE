using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public Sprite MusicOn, MusicOff;
    public bool music;
    private Image img;
    private float yPos;
    private Transform child;

    void Start()
    {

        img = GetComponent<Image>();
       // child = transform.GetChild(0).transform;
        if (music)
        {
            if (PlayerPrefs.GetString("Music") != "no")
            {
                //Музыка играет и можем ее выключить
                img.sprite = MusicOn;
                /*
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
                */

            }
            else
            {
                img.sprite = MusicOff;
                /* transform.GetChild(0).gameObject.SetActive(false);
                 transform.GetChild(1).gameObject.SetActive(true);
                 child = transform.GetChild(1).transform;*/
            }
        }
    }
    private void OnMouseDown()
    {
       /* img.sprite = pressed;
        yPos = child.localPosition.y;
        child.localPosition = new Vector3(child.localPosition.x, 0, child.localPosition.z);*/
    }
    private void OnMouseUp()
    {
       /* img.sprite = button;
        child.localPosition = new Vector3(child.localPosition.x, yPos, child.localPosition.z);*/
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name) {
            case "Play":
                StartCoroutine(loadScene("game")); //начинаем куротину,передаем название сцены на которую хотим переидти
                break;
            case "Music":
                // child.gameObject.SetActive(false);
                
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    img.sprite = MusicOff;
                    PlayerPrefs.SetString("Music", "no");
                    music = false;
                    // child = transform.GetChild(1).transform;
                    Debug.Log("11");
                }
                else
                {
                    PlayerPrefs.DeleteKey("Music");
                    img.sprite = MusicOn;
                    music = true;
                    // child = transform.GetChild(0).transform;
                }
                //child.gameObject.SetActive(true);
                break;
        }
    }
    IEnumerator loadScene(string scene)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1); //берем скрипт Fading и берем функцию BeginFade, от прозрачной до черного экран
        //возвращает время и переходим на другую сцену далее ФЛАГ1
            yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
    }
}
