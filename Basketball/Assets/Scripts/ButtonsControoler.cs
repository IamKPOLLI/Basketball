using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsControoler : MonoBehaviour
{


    [SerializeField] private AudioSource _ButtonClickAudion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void LoadPlayScene()
    {
        _ButtonClickAudion.Play();
        SceneManager.LoadScene("GameProcess");
    }

    public void LoadMenu()
    {
        _ButtonClickAudion.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
