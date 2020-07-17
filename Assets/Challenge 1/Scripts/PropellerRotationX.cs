using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotationX : MonoBehaviour
{

    private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 15.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // reset propeler if turned around
        if (transform.rotation.z == 180.0f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        transform.Rotate(new Vector3(0, 0, 30) * rotationSpeed * Time.deltaTime);
    }
}
