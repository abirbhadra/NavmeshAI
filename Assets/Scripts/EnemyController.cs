using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent agent;
    [SerializeField]
    Transform origin;
    LayerMask layerMask;
   
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        layerMask = LayerMask.GetMask("Wall", "Character");
    }

   
    private void FixedUpdate()
    {
        Ray ray = new Ray(origin.position, origin.transform.forward);
        Physics.Raycast(ray, out RaycastHit hit, 20f);
        if (hit.collider == null)
        {
            return;
        }
        if (hit.collider.gameObject.layer == 7)
        {
            agent.SetDestination(GameManager.instance.playerPostition.position);
        }
    }
}
