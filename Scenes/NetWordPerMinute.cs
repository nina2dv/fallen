using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetWordPerMinute : MonoBehaviour
{
    public float wpm;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        wpm = 0f;
        Timer.timeStart = 0;
        CorrectLetter.scoreLetterCount = 0;
        MistakeScore.mistakeCount = 0;

        text.text = wpm.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver.gameOver)
        {
            wpm = (((CorrectLetter.scoreLetterCount + MistakeScore.mistakeCount) / 5) - MistakeScore.mistakeCount) / (Timer.timeStart / 60);
            text.text = wpm.ToString("F2");
        }
    }
}
