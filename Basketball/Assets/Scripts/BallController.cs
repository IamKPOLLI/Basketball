using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{


    [SerializeField] private Rigidbody2D _body;
    private Vector2 _ballVelocity;
 
    // Start is called before the first frame update
    void Start()
    {
        _ballVelocity = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Move()
    {
        _ballVelocity.x = 0 - transform.position.x;
        _ballVelocity.y = 0 - transform.position.y;
        _ballVelocity = _ballVelocity.normalized;
        _body.velocity = _ballVelocity * 5;

    }

    public void TeleportToPosition(Vector2 pos)
    {
        transform.position = pos;
    }
}
