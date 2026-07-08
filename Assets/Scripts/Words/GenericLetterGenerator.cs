using System.Collections;
using System.Collections.Generic;
public static class GenericLetterGenerator
{
    public static List<letterValues> getLetterList()
    {
        List<letterValues> letterList = new List<letterValues>();
        for (int i = 0; i < 12; i++)
        {
            letterList.Add(letterValues.E);
        }
        for(int i =0; i < 9; i++)
        {
            letterList.Add(letterValues.A);
            letterList.Add(letterValues.I);
        }
        for (int i = 0; i < 8; i++)
        {
            letterList.Add(letterValues.O);
        }
        for (int i = 0; i < 6; i++)
        {
            letterList.Add(letterValues.N);
            letterList.Add(letterValues.R);
            letterList.Add(letterValues.T);
        }
        for (int i = 0; i < 4; i++)
        {
            letterList.Add(letterValues.D);
            letterList.Add(letterValues.L);
            letterList.Add(letterValues.S);
            letterList.Add(letterValues.U);
        }
        for(int i = 0; i < 3; i++)
        {
            letterList.Add(letterValues.G);
        }
        for(int i = 0; i < 2; i++)
        {
            letterList.Add(letterValues.B);
            letterList.Add(letterValues.C);
            letterList.Add(letterValues.M);
            letterList.Add(letterValues.P);
            letterList.Add(letterValues.F);
            letterList.Add(letterValues.H);
            letterList.Add(letterValues.V);
            letterList.Add(letterValues.W);
            letterList.Add(letterValues.Y);
            letterList.Add(letterValues.BLANK);
        }
        letterList.Add(letterValues.J);
        letterList.Add(letterValues.K);
        letterList.Add(letterValues.Q);
        letterList.Add(letterValues.X);
        letterList.Add(letterValues.Z);



        return letterList;
    }
    public static int GetWordValue(string word)
    {
        int value = 0;
        foreach(char letter in word)
        {
            value += (int)System.Enum.Parse(typeof(letterValues), letter.ToString());
        }
        return value;
    }
    public static int GetLetterValue(letterValues letter)
    {
        return (int)letter;
    }
}