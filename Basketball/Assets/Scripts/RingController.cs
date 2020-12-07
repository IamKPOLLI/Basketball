using UnityEngine;

public class RingController : MonoBehaviour
{
    
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
            _gameOverAudio.Play();
            Destroy(collision.gameObject);
            _gameController.currentGameState = GameController.GameState.end;
        }   
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _plusScoreAudio.Play();
            Destroy(collision.gameObject);
            _gameController.SumScore();
        }
    }


}
