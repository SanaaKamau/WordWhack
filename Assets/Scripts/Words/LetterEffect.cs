public class LetterEffect
{
    private letterValues LETTER;
    private LetterEffects EFFECT;

    public LetterEffect(letterValues letter)
    {
        this.LETTER = letter;
        this.EFFECT = LetterEffects.None;
    }
    public letterValues GetLetter()
    {
        return LETTER;
    }
    public int GetLetterValue()
    {
        if(EFFECT == LetterEffects.TL)
        {
            return (int)LETTER * 3;
        }
        else if(EFFECT == LetterEffects.DL)
        {
            return (int)LETTER * 2;
        }
        else if(EFFECT == LetterEffects.Heal)   
        {
            return (int)LETTER * 5;
        }
        else
        {
            return (int)LETTER;
        }
        
    }
  
    public LetterEffects GetEffect()
    {
        return EFFECT;
    }
    public void SetEffect(LetterEffects effect)
    {
        this.EFFECT = effect;
    }
}
public enum LetterEffects
{
    DL, /* double letter*/
    TL, /*triple letter*/
    DW, /*double word*/
    TW, /*triple word*/
    Heal, /* heals player by 5* the letter value*/
    None /* no effect*/

}