using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollector : MonoBehaviour
{
    public static int crystalCount = 0;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            crystalCount++;
            StartCoroutine(DestoryAfterDelay()); // Start coroutine with a 1-second delay
        }
    }

        IEnumerator DestoryAfterDelay()
    {
        yield return new WaitForSeconds(0.5f); // Wait for the specified delay
        Destroy(gameObject); // Destroy the crystal after the delay
    }
}
