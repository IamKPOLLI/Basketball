using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SaveBase : MonoBehaviour
{
    [SerializeField] private Text _bestScorelabel;
    [SerializeField] private GameController gameController;
    public int bestResult;

    
    private string data;





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
        data = JsonUtility.ToJson(this);
        File.WriteAllText(Path.Combine(Application.persistentDataPath,"Save"),data);
        _bestScorelabel.text = "Best Score:" + bestResult;
    }

    public void Load()
    {

        data = File.ReadAllText(Path.Combine(Application.persistentDataPath, "Save"));
        JsonUtility.FromJsonOverwrite(data, this);
        SetInfo();
        _bestScorelabel.text = "Best Score:" + bestResult;

    }


}
