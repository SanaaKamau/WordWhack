using Unity.VisualScripting;
using UnityEngine;

public class TileEffect
{
    private GameObject tile;
    private LetterEffect effect;
    public TileEffect(GameObject t, LetterEffect e)
    {
        tile = t;
        effect = e;
    }
    public GameObject GetObject()
    {
        return tile;
    }
    public LetterEffect GetLetterEffect()
    {
        return effect;
    }

}