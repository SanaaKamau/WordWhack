using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class GenericLetterGenerator
{
    public static List<LetterEffect> GetLetterList(int numOfTW, int numOfDW, int numOfTL, int numOfDL, int numOfHeal)
    {
        List<LetterEffect> letterList = new List<LetterEffect>();
        for (int i = 0; i < 12; i++)
        {
            letterList.Add(new LetterEffect(letterValues.E));
        }
        for(int i =0; i < 9; i++)
        {
            letterList.Add(new LetterEffect(letterValues.A));
            letterList.Add(new LetterEffect(letterValues.I));
        }
        for (int i = 0; i < 8; i++)
        {
            letterList.Add(new LetterEffect(letterValues.O));
        }
        for (int i = 0; i < 6; i++)
        {
            letterList.Add(new LetterEffect(letterValues.N));
            letterList.Add(new LetterEffect(letterValues.R));
            letterList.Add(new LetterEffect(letterValues.T));
        }
        for (int i = 0; i < 4; i++)
        {
            letterList.Add(new LetterEffect(letterValues.D));
            letterList.Add(new LetterEffect(letterValues.L));
            letterList.Add(new LetterEffect(letterValues.S));
            letterList.Add(new LetterEffect(letterValues.U));
        }
        for(int i = 0; i < 3; i++)
        {
            letterList.Add(new LetterEffect(letterValues.G));
        }
        for(int i = 0; i < 2; i++)
        {
            letterList.Add(new LetterEffect(letterValues.B));
            letterList.Add(new LetterEffect(letterValues.C));
            letterList.Add(new LetterEffect(letterValues.M));
            letterList.Add(new LetterEffect(letterValues.P));
            letterList.Add(new LetterEffect(letterValues.F));
            letterList.Add(new LetterEffect(letterValues.H));
            letterList.Add(new LetterEffect(letterValues.V));
            letterList.Add(new LetterEffect(letterValues.W));
            letterList.Add(new LetterEffect(letterValues.Y));
            letterList.Add(new LetterEffect(letterValues.BLANK));
        }
        letterList.Add(new LetterEffect(letterValues.J));
        letterList.Add(new LetterEffect(letterValues.K));
        letterList.Add(new LetterEffect(letterValues.Q));
        letterList.Add(new LetterEffect(letterValues.X));
        letterList.Add(new LetterEffect(letterValues.Z));
        letterList =AssignEffects(letterList, numOfTW, numOfDW, numOfTL, numOfDL, numOfHeal);
        return letterList;
    }
    public static int GetWordValue(List<LetterEffect> word)
    {
        int wordValue = 0;
        bool hasDW = false;
        bool hasTW = false;
        foreach(LetterEffect letter in word)
        {
            bool isDL = letter.GetEffect() == LetterEffects.DL;
            bool isTL = letter.GetEffect() == LetterEffects.TL;

            if (letter.GetEffect() == LetterEffects.DW)
            {
                hasDW = true;
            }
            else if (letter.GetEffect() == LetterEffects.TW)
            {
                hasTW = true;
            }
            wordValue += letter.GetLetterValue();
            
            
        }
        if(hasDW)
        {
            wordValue *= 2;
        }
        if (hasTW)
        {
            wordValue *= 3;
        }
        return wordValue;
    }
    //TODO: Update AssignEffects to assign effects to letters in a way that doesn't overwrite previously assigned effects
    private static List<LetterEffect> AssignEffects(List<LetterEffect> letterList, int numOfTW, int numOfDW, int numOfTL, int numOfDL, int numOfHeal)
    {
        List<LetterEffect> tempList = new List<LetterEffect>(letterList);
        for(int i = 0; i < numOfTW; i++)
        {       
            tempList[Random.Range(0, letterList.Count)].SetEffect(LetterEffects.TW);       
        }
        for (int i = 0; i < numOfDW; i++)
        {
            tempList[Random.Range(0, letterList.Count)].SetEffect(LetterEffects.DW);
        }
        for (int i = 0; i < numOfTL; i++)
        {
            tempList[Random.Range(0, letterList.Count)].SetEffect(LetterEffects.TL);
        }
        for (int i = 0; i < numOfDL; i++)
        {
            tempList[Random.Range(0, letterList.Count)].SetEffect(LetterEffects.DL);
        }
        for (int i = 0; i < numOfHeal; i++)
        {
            tempList[Random.Range(0, letterList.Count)].SetEffect(LetterEffects.Heal);
        }
        return tempList;
    }
}