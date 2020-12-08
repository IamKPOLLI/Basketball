using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Text _bestScoreLabel;
    [SerializeField] private AudioSource _clickButtonAudio;
    [SerializeField] private AudioSource _gameOverAudio;
    [SerializeField] private Button _playButton;
    [SerializeField] private GameController _gameController;
    [SerializeField] private RingController _ringController;
    [SerializeField] private Button _menuButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Text _scoreLabel;
    [SerializeField] private Text _resultLabel;

    public enum SceneState
    {
        menu,
        play,
        loss
    }

    public SceneState currentSceneState;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneState = SceneState.menu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void LoadGameProcess()
    {
        _clickButtonAudio.Play();
        _resultLabel.gameObject.SetActive(false);
        _playButton.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(false);
        _menuButton.gameObject.SetActive(false);
        _bestScoreLabel.gameObject.SetActive(false);
        _gameController.gameObject.SetActive(true);
        _gameController.currentGameState = GameController.GameState.start;
        _gameController.delay = 2;
        _gameController.SetScore(0);
        _ringController.gameObject.SetActive(true);
        _scoreLabel.gameObject.SetActive(true);
        _scoreLabel.text = "Score: 0";

    }

    public void LoadLossMenu()
    {
        _gameOverAudio.Play();
        _playButton.gameObject.SetActive(false);
        _scoreLabel.gameObject.SetActive(false);
        _gameController.gameObject.SetActive(false);
        _ringController.gameObject.SetActive(false);
        _bestScoreLabel.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(true);
        _menuButton.gameObject.SetActive(true);
        _resultLabel.gameObject.SetActive(true);
        _resultLabel.text = "Your score: " + _gameController.GetScore();
        

    }

    public void LoadMainMenu()
    {
        _clickButtonAudio.Play();
        _restartButton.gameObject.SetActive(false);
        _menuButton.gameObject.SetActive(false);
        _resultLabel.gameObject.SetActive(false);
        _playButton.gameObject.SetActive(true);
        _bestScoreLabel.gameObject.SetActive(true);
    }
}
