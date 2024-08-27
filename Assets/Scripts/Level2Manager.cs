using UnityEngine;

public class Level2Manager : MonoBehaviour
{

    public GameObject powerUpPrefab;

    void Start()
    {
        Debug.Log(CrystalCollector.crystalCount);
        // Spawn Power-ups based on crystal count
        if (CrystalCollector.crystalCount >= 5)
        {
            Instantiate(powerUpPrefab, new Vector3(49.8f, 4.03f, 43.99475f), Quaternion.identity);
        }

        // Change environment based on spirits defeated
        if (CrystalCollector.crystalCount <= 4)
        {
            RenderSettings.ambientLight = Color.red; // Darker environment
        }
        else
        {
            RenderSettings.ambientLight = Color.white; // Brighter environment
        }
    }
}
