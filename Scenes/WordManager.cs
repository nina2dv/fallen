using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WordManager : MonoBehaviour
{

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;


	
	public void AddWord()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());

		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
				CorrectLetter.scoreLetterCount++;

			}
            else
            {
				activeWord.IncorrectLetter();
				MistakeScore.mistakeCount++;

			}
		}
		else
		{
			foreach (Word word in words)
			{

				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					CorrectLetter.scoreLetterCount++;
					break;
                }
                else
                {
					activeWord = word;
					hasActiveWord = true;
					word.IncorrectLetter();
					MistakeScore.mistakeCount++;
					break;

				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
			try
			{
				words[0].NextWord();
				words[1].AfterWord();
				words[2].LaterWord();
			}
			catch (Exception e)
			{
				print(e);
			}

			Score.scoreCount += activeWord.word.Length;
		}
	}

}