using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputCharText : MonoBehaviour
{

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            text.text = letter.ToString();
        }
        
    }

}
