using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ABShooting : MonoBehaviour
{
    public KeyCode Return;
    public Transform shootingPoint;
    public GameObject bullet;
    public SpriteRenderer sr;


    public void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(Return))
        {
            Shooting(); //see function definition below
        }
    }

    public void Shooting()
    {
        Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);

    }
}