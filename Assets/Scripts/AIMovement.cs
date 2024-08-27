using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    [SerializeField] GameObject ResetMenu;

    public float radius = 10f; // Fixed radius within which the agent will move towards the target

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        // Check if the target is within the specified radius
        if (distanceToTarget <= radius)
        {
            agent.destination = target.position;
        }
        else
        {
            agent.ResetPath(); // Stop the agent if the target is out of range
        }
    }

    // if agent collide with compare tag popup reset menu
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ResetMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
