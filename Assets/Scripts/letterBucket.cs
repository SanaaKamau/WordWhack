using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class letterBucket
{
    List<letterValues> letterList = new List<letterValues>();
    List<letterValues> lettersInPlay = new List<letterValues>();

    public letterBucket()
    {
        letterList = GenericLetterGenerator.getLetterList();
    }
    public void ResetLetterList()
    {
        letterList = GenericLetterGenerator.getLetterList();
    }
    public void RemoveLetters(letterValues  [] lettersToRemove)
    {
        foreach(letterValues letter in lettersToRemove)
        {
            letterList.Remove(letter);
        }
    }
    public void DrawTwelve()
    {
        for(int i = 0; i < 12; i++)
        {
            lettersInPlay.Add(DrawLetter());
        }
        
    }
    public List<letterValues> GetLettersInPlay()
    {
        return lettersInPlay;
    }
    public letterValues DrawLetter()
    {
        letterValues drawnLetter = letterList[Random.Range(0, letterList.Count)];
        letterList.Remove(drawnLetter);
        return drawnLetter;
    }
    public void AddDifference()
    {
        int difference = 12 - lettersInPlay.Count;
      
        for(int i = 0; i < difference; i++)
        {
            if(BucketIsEmpty())
            {
                ResetLetterList();
            }
            lettersInPlay.Add(DrawLetter());
        }
    }
    private bool BucketIsEmpty()
    {
        return letterList.Count == 0;
    }
   
    
}
