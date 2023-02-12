using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{

    public static bool gameOver = false;
    public GameObject text;
    public Text text1;
    public GameObject button;
    void Start()
    {
        gameOver = false;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Word")
        {
            gameOver = true;
            Debug.Log("GAME OVER");
            text.SetActive(true);
            // text1 = text.GetComponent<Text>();
            // text1.color = new Color(170, 66, 47, 255);


            Time.timeScale = 0;

            // button.SetActive(true);
            // GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Word");
            // foreach (GameObject obj in allObjects)
            {
                //Destroy(obj);
            }
        }
    }

    public bool GetGameOver()
    {
        return gameOver;
    }
}