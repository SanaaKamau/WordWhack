using System.Collections;
using System.Collections.Generic;
public class letterBucket
{
    List<letterValues> letterList = new List<letterValues>();
    letterList
}
public enum letterValues
{ 
    A,E,I,O = 1,
    X,Y,Z = 10,
    F,H,V,W, K,M,P= 4,
    Q,J = 8,
    B,C,D,G, L,N,R= 3,
    S,T,U = 2,
    BLANK = 0

}
public static class getGenericLetterRatio
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
}