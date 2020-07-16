﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;

    public PlayerController()
    {
        Speed = 5.0f;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);

        if (Speed < 80)
        {
            Speed = Speed + Time.deltaTime * 10;
        }

    }
}

