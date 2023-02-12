using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MistakeScore : MonoBehaviour
{
    public static int mistakeCount;
    public Text text;
    GameOver block;
    [SerializeField] GameObject square;

  
    void wake()
    {
        
    }
    void Start()
    {
        mistakeCount = 0;
        block = square.GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!block.GetGameOver())
        {
            text.text = mistakeCount.ToString();
        }
    }
}
