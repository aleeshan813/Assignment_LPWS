using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerUpTrigger : MonoBehaviour
{
    [SerializeField] GameObject bang;
    [SerializeField] GameObject WinMenu;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
           bang.SetActive(true);
            StartCoroutine(Win());
        }
    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(2);
        WinMenu.SetActive(true);
        
    }
}