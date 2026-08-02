using System.Collections.Generic;
using UnityEngine;

public class DictionaryManager : MonoBehaviour
{
    private HashSet<string> words = new HashSet<string>();

    public void LoadDictionary()
    {
        TextAsset dictionary = Resources.Load<TextAsset>("words");

        if (dictionary == null)
        {
            Debug.LogError("Dictionary.txt not found!");
            return;
        }

        foreach (string line in dictionary.text.Split('\n'))
        {
            string word = line.Trim().ToUpper();
            //Debug.Log($"Loaded word: {word}");

            if (!string.IsNullOrEmpty(word))
                words.Add(word);
        }
    }

    public bool IsWord(string word)
    {
        word = word.Trim().ToUpper();
        bool isWord = words.Contains(word);
        Debug.Log($"Checking if '{word}' is a valid word: {isWord}");
        if (!isWord)
        {
            Debug.LogWarning($"Word '{word}' not found in the dictionary.");
        }
        if (isWord)
        {
            Debug.Log($"Word '{word}' found in the dictionary.");
        }
        return isWord;
    }
}