using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BackToSelect : MonoBehaviour
{
    public void BackToLevel()
    {
        SceneManager.LoadScene(1);
    }
}
