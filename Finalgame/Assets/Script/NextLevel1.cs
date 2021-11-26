using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel1 : MonoBehaviour
{
    public PlayerController Player;
    private int score = 0;
    public int minGhost = 12; //<<<<ของใหม่
    public int nextState;//<<<<ของใหม่
    public void AddScore()
    {
        score = score + 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int scorePlayer  = collision.gameObject.GetComponent<PlayerController>().score;
            if (scorePlayer < minGhost)
            {
                print("stay!");
                //SceneManager.LoadScene(2);

            }
            else
            {
                print("Go!");
                SceneManager.LoadScene(nextState);//chap1.1
            }
  

        }
 
    }
}
