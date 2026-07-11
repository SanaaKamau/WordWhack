using System.Collections.Generic;
using UnityEngine;

public class DictionaryManager : MonoBehaviour
{
    private HashSet<string> words = new HashSet<string>();

    private void Awake()
    {
        TextAsset dictionary = Resources.Load<TextAsset>("Dictionary");

        if (dictionary == null)
        {
            Debug.LogError("Dictionary.txt not found!");
            return;
        }

        foreach (string line in dictionary.text.Split('\n'))
        {
            string word = line.Trim().ToUpper();

            if (!string.IsNullOrEmpty(word))
                words.Add(word);
        }
    }

    public bool IsWord(string word)
    {
        return words.Contains(word.ToUpper());
    }
}