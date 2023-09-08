using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Y Position of the player
    private float yPosition;

    //Laser for player
    [SerializeField] private GameObject laser;

    void Start()
    {
        //Locks the Y
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(position.x, yPosition);

        //Spawns laser
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
}
