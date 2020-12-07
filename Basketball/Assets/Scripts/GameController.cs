using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private SaveBase _saveBase;
    [SerializeField] private SceneController _sceneController;
    [SerializeField] private BallController _ballPrefab;
    [SerializeField] private Text _scoreLabel;
    private int _score = 0;
    public int bestResult;
  

    


    private float[] _PositionsForBallsX = { -4, -4, 4, 4, 8, -8, 0, 0 };
    private float[] _PositionsForBallsY = { 8, -8, 8, -8, 0, 0, 8, -8 };
    private int _randomPos;
    public int numberOfBalls = 5;
    public float delay = 2;
    public enum GameState
    {
        start,
        work,
        end
    }
    public GameState currentGameState;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentGameState)
        {
            case GameState.start:

                _scoreLabel.text = "Score: " + _score;
                StartCoroutine(StartBalls(delay));
                currentGameState = GameState.work;
                break;
            case GameState.work:
                break;
            case GameState.end:
                GameObject[] gameobjects = GameObject.FindGameObjectsWithTag("Ball");
                if (gameobjects != null)
                {
                    for (int i = 0; i < gameobjects.Length; i++)
                    {
                        Destroy(gameobjects[i]);
                    }
                }
                if(_score > bestResult)
                {
                    bestResult = _score;
                    _saveBase.Save();
                }
                _sceneController.LoadLossMenu();
                break;

        }
       
    }


    void AddBall()
    {
        BallController ball = Instantiate(_ballPrefab) as BallController;
        _randomPos = Random.Range(0, _PositionsForBallsX.Length);
        ball.TeleportToPosition(new Vector2(_PositionsForBallsX[_randomPos], _PositionsForBallsY[_randomPos]));
        ball.Move();
        
    }


    private IEnumerator StartBalls(float delay)
    {

        for (int i = 0; i < numberOfBalls; i++)
        {


            AddBall();
            yield return new WaitForSeconds(delay);
        }

        ChangeGameDifficulty();
    }

    public void ChangeGameDifficulty()
    {
        if (delay >= 0.6)
        {
            delay -= 0.5f;
        }

        currentGameState = GameState.start;
    }

    public void SumScore()
    {
        _score += 1;
        _scoreLabel.text = "Score: " + _score;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int sc)
    {
        _score = sc;
    }

    



}
