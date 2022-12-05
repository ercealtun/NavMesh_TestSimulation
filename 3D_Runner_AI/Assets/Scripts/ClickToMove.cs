using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent m_Agent;
    private RaycastHit m_HitInfo = new RaycastHit();
    // Start is called before the first frame update
    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo)) // Go where clicked
            {
                m_Agent.destination = m_HitInfo.point;
            }
        }

    }
}
