using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StartPage : MonoBehaviour
{
    public void GoToStartPage()
    {
        SceneManager.LoadScene(0);
    }
}
