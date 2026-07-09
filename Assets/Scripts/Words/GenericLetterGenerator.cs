using System.Collections;
using System.Collections.Generic;
public static class GenericLetterGenerator
{
    public static List<LetterEffect> getLetterList(int numOfTW, int numOfDW, int numOfTL, int numOfDL, int numOfHeal)
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
            if (isDL)
            {
                wordValue += letter.GetLetterValue() * 2;
            }
            else if (isTL)
            {
               wordValue += letter.GetLetterValue() * 3;
            }
            else if (letter.GetEffect() == LetterEffects.DW)
            {
                hasDW = true;
            }
            else if (letter.GetEffect() == LetterEffects.TW)
            {
                hasTW = true;
            }
            else
            {
                wordValue += letter.GetLetterValue();
            }
            
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
    {
        
    }
}