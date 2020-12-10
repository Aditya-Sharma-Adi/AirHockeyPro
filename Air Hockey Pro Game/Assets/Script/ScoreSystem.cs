using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject buck1;
    public GameObject buck2;
    public GameObject buck3;
    public GameObject buck4;
    public GameObject buck5;
    public GameObject buck6;

    public GameObject Player1Win;
    public GameObject Player2Win;

    public bool player1foul;
    public bool player2foul;

    public int player1Score=3;
    public int player2Score=3;

    public GameObject player1;
    public GameObject player2;

    public float foul1Time;
    public float foul2Time;

    public GameObject foul1;
    public GameObject foul2;
    public GameObject resumeBut;

    public Animator foul1Animation;
    public Animator foul2Animation;

    void Start()
    {
        Player1Win.SetActive(false);
        Player2Win.SetActive(false);
        foul1.SetActive(false);
        foul2.SetActive(false);
    }

    void Update()
    {


        if ((buck1.transform.position.y > 0.5f && buck2.transform.position.y > 0.5f && buck3.transform.position.y > 0.5f && buck4.transform.position.y > 0.5f &&
           buck5.transform.position.y > 0.5f && buck6.transform.position.y > 0.5f)|| foul2Time >= 5.0f)
        {
            Time.timeScale = 0;
            Player1Win.SetActive(true);
            Player2Win.SetActive(false);
            foul1.SetActive(false);
            foul2.SetActive(false);
        }

         if ((buck1.transform.position.y < -0.6f && buck2.transform.position.y < -0.6f && buck3.transform.position.y < -0.6f && buck4.transform.position.y < -0.6f &&
            buck5.transform.position.y < -0.6f && buck6.transform.position.y < -0.6f)|| foul1Time >= 5.0f)
         {
            Time.timeScale = 0;
            foul2Time = 5;
              Player2Win.SetActive(true);
              Player1Win.SetActive(false);
            foul1.SetActive(false);
            foul2.SetActive(false);
         }
       

    }

     void FixedUpdate()
    {
        if (player1.transform.position.y > -1.4f && player1.transform.position.x > -0.66f && player1.transform.position.x < 0.65f)

        {
            foul1Time += Time.deltaTime;
            player1foul = true;
           
        }
        else
        {
            foul1Time = 0;
            player1foul = false;
        }

        if (player2.transform.position.y < 1.4 && player2.transform.position.x > -0.65f && player2.transform.position.x < 0.65f)
        {
            foul2Time += Time.deltaTime;
            player2foul = true;
        }
        else
        {
            foul2Time = 0;
            player2foul = false;
        }

        if (foul1Time >= 2 && player1foul == true)
        {
            foul1.SetActive(true);
            foul2Animation.SetTrigger("Foul");
        }
        else if (player1foul == false && foul1Time <= 2) 
        {
            foul1.SetActive(false);
           
        }
        if (foul2Time >= 2 && player2foul == true)
        {
            foul2.SetActive(true);
            resumeBut.SetActive(false);
            foul2Animation.SetTrigger("Foul");
        }
        else if (player2foul == false && foul2Time <= 2) 
        {
            foul2.SetActive(false);
            if (GameManager.instance.isPalying == true) 
            resumeBut.SetActive(true);
        }

    }


}
