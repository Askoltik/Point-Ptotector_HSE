using System.Collections;
using UnityEngine;

public class Fading : MonoBehaviour
{
    public Texture2D fadeOutTexture;

    private float fadeSpeed = 0.8f;
    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;
    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime; // плавное погасание
        alpha = Mathf.Clamp01(alpha); //устанавливает предел от 0 до 1

        GUI.color = new Color(GUI.color.r,GUI.color.g,GUI.color.b,alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return fadeSpeed;
    }
    private void OnEnable() 
    {
        //При переходе на сцену начнет появление сцены
        BeginFade(-1);
    }
}
