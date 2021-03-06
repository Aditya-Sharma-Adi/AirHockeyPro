﻿using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{ 
   
    Vector2 playerSize;

    Rigidbody2D rb;
    public Collider2D playerCollider { get; private set;}
    public Transform BoundaryHolder;
   

    public PlayerController playerController;

    public int? LockedFingerID { get; set; }

    Boundary playerBoundary;
 

    struct Boundary
    {
        public float Up, Down, Left, Right;

        public Boundary(float up, float down, float left, float right)
        {
            Up = up; Down = down; Left = left; Right = right;
        }
    }
    

    // Use this for initialization
    void Start()
    {
        playerSize = GetComponent<SpriteRenderer>().bounds.extents;
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerBoundary = new Boundary(BoundaryHolder.GetChild(0).position.y,
                                      BoundaryHolder.GetChild(1).position.y,
                                      BoundaryHolder.GetChild(2).position.x,
                                      BoundaryHolder.GetChild(3).position.x);
       

    }

    public void OnEnabel()
    {
        playerController.players.Add(this);
    }

    public void OnDisable()
    {
        playerController.players.Remove(this);
    }
   

    public void MoveToPosition(Vector2 position)
    {
        Vector2 clampedMousePos = new Vector2(Mathf.Clamp(position.x, playerBoundary.Left,
                                                                 playerBoundary.Right),
                                                     Mathf.Clamp(position.y, playerBoundary.Down,
                                                                 playerBoundary.Up));
        rb.MovePosition(clampedMousePos);
    }
}