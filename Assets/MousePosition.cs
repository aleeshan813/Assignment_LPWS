using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    public GameObject ancientstonePrefab;
    public Camera cam; // Reference to the camera
    public float rayRange = 100f; // The distance the ray will travel

    void Update()
    {
        // Check if the left mouse button was pressed
        if (Input.GetMouseButtonDown(0))
        {
            ShootRay();
        }
    }

    void ShootRay()
    {
        // Create a ray from the camera going forward
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if the ray hits anything within the range
        if (Physics.Raycast(ray, out hit, rayRange))
        {
            // Check if the object hit has the tag "Enemy"
            if (hit.collider.CompareTag("Enemy"))
            {
                Instantiate(ancientstonePrefab, new Vector3(36.67f, 8.68f, 38.35993f), Quaternion.identity);
                Destroy(hit.collider.gameObject); // Destroy the enemy
            }
        }
    }
}
