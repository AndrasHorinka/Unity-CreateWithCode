using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Vehicle;
    public float cameraChanger;
    private Vector3 fromBehind;
    private Vector3 fromInside;
    private Vector3 cameraPerspective;
    private bool isCameraFromBehind;



    // Start is called before the first frame update
    void Start()
    {
        isCameraFromBehind = true;
        fromBehind = new Vector3(0, 5, -20);
        fromInside = new Vector3(0, 5, 5);
        cameraPerspective = fromBehind;
    }

    // Update is called once per frame
    void Update()
    {
        cameraChanger = Input.GetAxis("Jump");

        if (cameraChanger * Time.deltaTime * 100 >= 1)
        {
            ChangeCameraPosition();
        }

        transform.position = Vehicle.transform.position + cameraPerspective;
    }

    void ChangeCameraPosition()
    {
        if (isCameraFromBehind)
        {
            cameraPerspective = fromInside;
            isCameraFromBehind = false;
        }
        else
        {
            cameraPerspective = fromBehind;
            isCameraFromBehind = true;
        }
    }
}
