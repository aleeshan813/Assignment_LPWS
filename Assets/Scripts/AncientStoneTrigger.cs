using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AncientStoneTrigger : MonoBehaviour
{
    public bool isActivated = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivated = true;
        }

        NextLevel();
    }


    public void NextLevel()
    {
        if (isActivated) 
        {
            SceneManager.LoadScene("Level_2");
        }
    }
}
