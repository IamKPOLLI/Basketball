using UnityEngine;

public class RingRotate : MonoBehaviour
{
    private Camera _camera;
    public float sensitivityVert = 35f;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(0))
       {


            var p1 = _camera.ScreenToViewportPoint(Input.mousePosition);
            var p2 = _camera.WorldToViewportPoint(transform.position);
            var p3 = p2 - p1;

            var angle = Mathf.Atan2(p3.y, p3.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle -66.103f, Vector3.forward);

            

        }

    }
}
