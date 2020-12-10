using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public List<PlayerMovement> players = new List<PlayerMovement>();

    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
            foreach (var  Player in players)
            {
                if (Player.LockedFingerID == null)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began && Player.playerCollider.OverlapPoint(touchPos))
                    {
                        Player.LockedFingerID = Input.GetTouch(i).fingerId;
                    }
                }
                else if (Player.LockedFingerID == Input.GetTouch(i).fingerId)
                {
                    Player.MoveToPosition(touchPos);
                    if (Input.GetTouch(i).phase == TouchPhase.Ended || Input.GetTouch(i).phase == TouchPhase.Canceled)
                    {
                        Player.LockedFingerID = null;
                    }
                }
            }
        }

    }
}
