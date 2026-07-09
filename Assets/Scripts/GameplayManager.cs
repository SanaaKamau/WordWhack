
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public LetterBucket letterBucket;
    public List<LetterEffect> lettersInPlay;
    public GameObject basicLetterPrefab;
    public GameObject dwLetterPrefab;
    public GameObject twLetterPrefab;
    public GameObject dlLetterPrefab;
    public GameObject tlLetterPrefab; 
    public GameObject dockPanel;
    public GameObject leftoverLettersPanel;
    public TMP_Text wordPowerText;
    private List<GameObject> leftoverLetterObjects = new List<GameObject>();
    private List<GameObject> dockLetterObjects = new List<GameObject>();

   void Awake()
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
  void Start()
    {
        letterBucket = new LetterBucket();
        letterBucket.DrawTwelve();
        lettersInPlay = letterBucket.GetLettersInPlay();
        foreach(LetterEffect letter in lettersInPlay)
        {
            GameObject letterObject = CreateTile(letter);
            leftoverLetterObjects.Add(letterObject);
        }
    }
    private GameObject CreateTile(LetterEffect letter)
    {
        GameObject letterPrefab;
        int letterValue = letter.GetLetterValue();
        if(letter.GetEffect() == LetterEffects.DW)
        {
            letterPrefab = dwLetterPrefab;
        }
        else if(letter.GetEffect() == LetterEffects.TW)
        {
            letterPrefab = twLetterPrefab;
        }
        else if(letter.GetEffect() == LetterEffects.DL)
        {
            letterPrefab = dlLetterPrefab;
        }
        else if(letter.GetEffect() == LetterEffects.TL)
        {
            letterPrefab = tlLetterPrefab;
        }
        else
        {
            letterPrefab = basicLetterPrefab;
        }
        TMP_Text[] textComponents = letterPrefab.GetComponentsInChildren<TMP_Text>();
        TMP_Text letterText = textComponents[0];
        TMP_Text letterValueText = textComponents[1];
        letterText.text = letter.GetLetter().ToString();
        letterValueText.text = letterValue.ToString();
        
        return Instantiate(letterPrefab, dockPanel.transform);
    }
    private void RemoveTile(GameObject letterObject)
    {
        dockLetterObjects.Remove(letterObject);
        Destroy(letterObject);
    }   
    private void DestroyDockTiles()
    {
        foreach(GameObject letterObject in dockLetterObjects)
        {
            Destroy(letterObject);
        }
        dockLetterObjects.Clear();
    }
    //private AddToLeftoverPanel()

}
