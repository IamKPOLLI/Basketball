using UnityEngine;

public class RingRotate : MonoBehaviour
{
   
    private float _startRotationZ = 23.897f;
    private float _rotationZ;
    public float sensitivityVert = 35f;

    // Start is called before the first frame update
    void Start()
    {
        _rotationZ = _startRotationZ;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _rotationZ += Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationZ = Mathf.Clamp(_rotationZ, -90 + 23.897f, 90 + 23.897f);
            transform.localEulerAngles = new Vector3(0, 0, _rotationZ);

        }

    }
}
