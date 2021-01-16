using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private VolumeController _volumeController;
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
        if (_volumeController.GetVolume())
        {
            _ButtonClickAudion.Play();
        }
        
       
    }
}
