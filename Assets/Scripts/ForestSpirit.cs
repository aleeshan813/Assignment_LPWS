using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpirit : MonoBehaviour
{
    public static int spiritsDefeated = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerWeapon"))
        {
            spiritsDefeated++;
            Destroy(gameObject);
        }
    }
}
