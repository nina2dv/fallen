using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{

	public WordManager wordManager;

	public float wordDelay = 1.5f;
	private float nextWordTime = 3f;
	public bool firstTime;
	void Start()
    {
		firstTime = true;
    }
	
	private void Update()
	{
		if (Time.time >= nextWordTime)
		{
			wordManager.AddWord();
			
			if (firstTime)
            {
				wordManager.AddWord();
				wordManager.AddWord();
				wordManager.words[0].NextWord();
				wordManager.words[1].AfterWord();
				wordManager.words[2].LaterWord();
				firstTime = false;
			}
			nextWordTime = Time.time + wordDelay;
			wordDelay *= .999f;
		}
	}

}