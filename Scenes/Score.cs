using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreCount;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = scoreCount.ToString();
    }

}
