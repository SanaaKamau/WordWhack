
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //classes
    DictionaryManager dictionary = new();
    public HealthBar playerHealth = new();
    public HealthBar enemyHealth = new();
    public LetterBucket letterBucket;
    public List<LetterEffect> lettersInPlay;
    public List<LetterEffect> lettersInDock;

    //Variables
    

    //UI Prefabs
    public GameObject basicLetterPrefab;
    public GameObject dwLetterPrefab;
    public GameObject twLetterPrefab;
    public GameObject dlLetterPrefab;
    public GameObject tlLetterPrefab; 
    public GameObject healLetterPrefab;

    //UI
    public Button hitButton;
    public GameObject dockPanel;
    public GameObject leftoverLettersPanel;
    public TMP_Text wordPowerText;

    //"Containers"
   // private List<GameObject> leftoverLetterObjects = new List<GameObject>();
    //private List<GameObject> dockLetterObjects = new List<GameObject>();

    private List<TileEffect> leftoverLetters = new List<TileEffect>();
    private List<TileEffect> dockLetters = new List<TileEffect>();

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
        hitButton.onClick.AddListener(OnHitButtonCLicked);
        letterBucket = new LetterBucket();
        letterBucket.DrawTwelve();
        lettersInPlay = letterBucket.GetLettersInPlay();
        foreach(LetterEffect letter in lettersInPlay)
        {
            GameObject letterObject = CreateTile(letter);
            //eftoverLetterObjects.Add(letterObject);
            leftoverLetters.Add(new TileEffect(letterObject,letter));
        }
    }
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (hit.collider != null)
        {
            GameObject clickedObject = hit.collider.gameObject;
            Debug.Log("ClickedObject name:" + clickedObject.name);
            if(clickedObject.CompareTag("LetterBox"))
            {
                Debug.Log("Clicked on a LetterBox : " + clickedObject.name);
                MoveTileToOppositePanel(GetCorrespondingTile(clickedObject));
            }
            Debug.Log(clickedObject.name);
            }
            else
            {
                Debug.Log("No object was clicked.");
            }
        
        Debug.Log("Mouse clicked at: " + mousePos);
    }
        UpdateWordValue();
    }
    private void UpdateWordValue()
    {
       // wordPowerText.text = GenericLetterGenerator.GetWordAttackValue(GetCurrentWord());
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
        else if(letter.GetEffect() == LetterEffects.Heal)
        {
            letterPrefab = healLetterPrefab;
        }
        else
        {
            letterPrefab = basicLetterPrefab;
        }
        TMP_Text[] textComponents = letterPrefab.GetComponentsInChildren<TMP_Text>();
        TMP_Text letterText = textComponents[0];
        TMP_Text letterValueText = textComponents[1];
        letterPrefab.tag ="LetterBox";
        
        if(letter.GetLetter() == letterValues.BLANK)
        {
            letterText.text = " ";
            letterValueText.text = "0";
            return Instantiate(letterPrefab, leftoverLettersPanel.transform);
        }   
        letterText.text = letter.GetLetter().ToString();
        letterValueText.text = letterValue.ToString();
        
        return Instantiate(letterPrefab, leftoverLettersPanel.transform);
    }
    public void MoveTileToOppositePanel(TileEffect letterObject)
    {
        if(letterObject.GetObject().transform.parent == leftoverLettersPanel.transform)
        {
            letterObject.GetObject().transform.SetParent(dockPanel.transform, false);
            dockLetters.Add(new TileEffect(letterObject.GetObject(),letterObject.GetLetterEffect()));
            leftoverLetters.Remove(letterObject);
            //lettersInDock.Add
        }
        else if(letterObject.GetObject().transform.parent == dockPanel.transform)
        {
            letterObject.GetObject().transform.SetParent(leftoverLettersPanel.transform, false);
            leftoverLetters.Add(letterObject);
            dockLetters.Remove(letterObject);
        }
    }
    public TileEffect GetCorrespondingTile(GameObject tile)
    {
        TileEffect foundTile = null;
        foreach(TileEffect t in leftoverLetters)
        {
            if(t.GetObject() == tile)
            {
                return t;
            }
        }
        foreach(TileEffect t in dockLetters)
        {
            if(t.GetObject() == tile)
            {
                return t;
            }
        }
        return foundTile;
    }
    private void RemoveTile(TileEffect letterObject)
    {
        dockLetters.Remove(letterObject);
        Destroy(letterObject.GetObject());
    }   
    private void DestroyDockTiles()
    {
        foreach(TileEffect TileEffect in dockLetters)
        {
            RemoveTile(TileEffect);
        
        }
        dockLetters.Clear();
    }
    private void OnHitButtonCLicked()
    {
        if (dictionary.IsWord(GetCurrentWord().ToUpper()))
        {
            DestroyDockTiles();
            Debug.Log("Dock tiles destroyed");        
        }   
    }
    private string GetCurrentWord()
    {
       
        string word = "";
        foreach (Transform child in dockPanel.transform)
        {
        TMP_Text[] textComponents = child.GetComponentsInChildren<TMP_Text>();
        TMP_Text letterText = textComponents[0];
            word += letterText.text;
        }

        Debug.Log("WORD IS:" +word);
        return word;
        }
        
    }
    
    //private AddToLeftoverPanel()


