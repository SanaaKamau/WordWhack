using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LetterBucket
{
    private List<LetterEffect> letterBucket = new List<LetterEffect>();
    private List<LetterEffect> lettersInPlay = new List<LetterEffect>();


    public LetterBucket()
    {
        letterBucket = GenericLetterGenerator.getLetterList();
    }
    public void ResetLetterList()
    {
        letterBucket = GenericLetterGenerator.getLetterList();
    }
    public void RemoveLetters(letterValues  [] lettersToRemove)
    {
        foreach(letterValues letter in lettersToRemove)
        {
            letterBucket.Remove(letter);
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
        letterValues drawnLetter = letterBucket[Random.Range(0, letterBucket.Count)];
        letterBucket.Remove(drawnLetter);
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
        return letterBucket.Count == 0;
    }
   
    
}
