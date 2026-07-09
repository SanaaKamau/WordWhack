
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public LetterBucket letterBucket;
    public GameObject letterPrefab;

    public void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
       
    }
 public Start()
    {
        letterBucket = new LetterBucket();
        letterBucket.DrawTwelve();
    }

}
