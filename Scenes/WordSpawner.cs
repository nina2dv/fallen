using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

	public GameObject wordPrefab;
	public Transform wordCanvas;

	public WordDisplay SpawnWord()
	{
		Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 7f);

		GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
		wordObj.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, Random.Range(0f, 360f)));
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		return wordDisplay;
	}

}