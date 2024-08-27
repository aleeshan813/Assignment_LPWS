using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Restart level
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level_1");
    }

    public void close()
    {
        this.gameObject.SetActive(false);
    }
}
