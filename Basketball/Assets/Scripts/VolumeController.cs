using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioSource _backgroundSound;
    private bool _volume;




    private void Start()
    {
        _volume = true;
    }
    public void ChangeVolume()
    {
        ChangeBackSoundVolume();
        _volume = !_volume;
    }
    public bool GetVolume()
    {
        return _volume;
    }
    public void ChangeBackSoundVolume()
    {
        if(_backgroundSound.volume == 0)
        {
            _backgroundSound.volume = 1;
        }
        else
        {
            _backgroundSound.volume = 0;
        }
        
    }
}
