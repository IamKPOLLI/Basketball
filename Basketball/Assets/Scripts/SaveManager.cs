using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private Text _bestScorelabel;
    [SerializeField] private GameController gameController;
    public int bestResult;

    
    

    private void Start()
    {
        Load();
        
    }
    public void CollectInfo()
    {
        bestResult = gameController.bestResult;
    }

    public void SetInfo()
    {
        gameController.bestResult = bestResult;
    }


    public void Save()
    {
        CollectInfo();
        PlayerPrefs.SetInt("bestScore", bestResult);
        PlayerPrefs.Save();
        _bestScorelabel.text = "Best Score:" + bestResult;
    }

    public void Load()
    {

        if (PlayerPrefs.HasKey("bestScore"))
        {
            bestResult = PlayerPrefs.GetInt("bestScore");
        }
        else
        {
            PlayerPrefs.SetInt("bestScore", bestResult);
            PlayerPrefs.Save();
            bestResult = 0;
        }
        SetInfo();
        _bestScorelabel.text = "Best Score:" + bestResult;

    }


}
