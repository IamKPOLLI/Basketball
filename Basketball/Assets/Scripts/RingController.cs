﻿using System.Collections;
using UnityEngine;

public class RingController : MonoBehaviour
{
    [SerializeField] private VolumeController _volumeController;
    [SerializeField] private AudioSource _plusScoreAudio;
    [SerializeField] private AudioSource _gameOverAudio;
    [SerializeField] private GameController _gameController; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if(_volumeController.GetVolume())
            {
                _gameOverAudio.Play();
            }
            
            Destroy(collision.gameObject);
            _gameController.currentGameState = GameController.GameState.end;
        }   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (_volumeController.GetVolume())
            {
                _plusScoreAudio.Play();
            }
            
            Destroy(collision.gameObject);
           // StartCoroutine(Delete(collision.gameObject));
            _gameController.SumScore();
        }
    }


   /* private IEnumerator Delete(GameObject gameObject)
    {

       
            yield return new WaitForSeconds(2);
        Destroy(gameObject);
       
    }*/


}
