using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField]Camera cam;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); // ray coming out of camera at the point i am clicking
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                //agent.Move(hit.point);
                agent.SetDestination(hit.point);
            }
        }
    }
}
