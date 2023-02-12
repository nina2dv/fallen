
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

	public Text text;
	public float fallSpeed = 1f;


	public void SetWord(string word)
	{
		text.text = word;

		text.GetComponent<BoxCollider2D>().size = new Vector2(text.preferredWidth, 34);

		// text.GetComponent<BoxCollider2D>().size = new Vector2(text.GetComponent<RectTransform>().sizeDelta.x, text.GetComponent<RectTransform>().sizeDelta.y);
	}

	public void RemoveLetter()
	{
		text.text = text.text.Remove(0, 1);
		text.color = new Color32(1, 152, 117, 255);
		text.GetComponent<BoxCollider2D>().size = new Vector2(text.preferredWidth, 35);
	}
	public void IncorrectInput()
    {
		text.color = new Color32(178, 34, 34, 255);
	}

	public void RemoveWord()
	{
		Destroy(gameObject);
	}

	public void NewWord()
    {
		text.color = new Color32(176, 143, 32, 255);
	}
	public void SecondNewWord()
	{
		text.color = new Color32(98, 85, 33, 255);
	}

	public void ThirdNewWord()
	{
		text.color = new Color32(60, 55, 34, 255);
	}


	private void Update()
	{
		// transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

}