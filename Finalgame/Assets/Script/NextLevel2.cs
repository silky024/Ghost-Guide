using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel2 : MonoBehaviour
{
    //public void GoToChapter12()
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Go!");
            SceneManager.LoadScene(4);//chap1.2

        }

    }
}
