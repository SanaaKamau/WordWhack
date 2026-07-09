using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LetterBucket
{
    private List<LetterEffect> letterBucket = new List<LetterEffect>();
    private List<LetterEffect> lettersInPlay = new List<LetterEffect>();
    private int numOfTW;
    private int numOfDW;
    private int numOfTL;
    private int numOfDL;
    private int numOfHeal;


    public LetterBucket()
    {
        numOfTW = 2;
        numOfDW = 2;
        numOfTL = 4;
        numOfDL = 6;
        numOfHeal = 5;
        letterBucket = GenericLetterGenerator.GetLetterList(numOfTW, numOfDW, numOfTL, numOfDL, numOfHeal);
    }
    public LetterBucket(int numOfTW, int numOfDW, int numOfTL, int numOfDL, int numOfHeal)
    {
        this.numOfTW = numOfTW;
        this.numOfDW = numOfDW;
        this.numOfTL = numOfTL;
        this.numOfDL = numOfDL;
        this.numOfHeal = numOfHeal;
        letterBucket = GenericLetterGenerator.GetLetterList(numOfTW, numOfDW, numOfTL, numOfDL, numOfHeal);
    }

    public void ResetLetterList()
    {
        letterBucket = GenericLetterGenerator.GetLetterList(numOfTW, numOfDW, numOfTL, numOfDL, numOfHeal);
    }
    public void RemoveLetters(LetterEffect[] lettersToRemove)
    {
        foreach(LetterEffect letter in lettersToRemove)
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
    public List<LetterEffect> GetLettersInPlay()
    {
        return lettersInPlay;
    }
    public LetterEffect DrawLetter()
    {
        LetterEffect drawnLetter = letterBucket[Random.Range(0, letterBucket.Count)];
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
