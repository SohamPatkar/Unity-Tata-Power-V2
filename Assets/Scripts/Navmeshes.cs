using UnityEngine;
using UnityEngine.AI;


public class Navmeshes : MonoBehaviour
{
    public Transform target;
    private NavMeshPath path;
    public LineRenderer lineRenderer;
    private float elapsed = 0.0f;
    [SerializeField]
    public GameObject _arrowDirection;
    // Start is called before the first frame update
    void Start()
    {
        path = new NavMeshPath();
        elapsed = 0.0f;
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed > 1.0f)
        {
            elapsed -= 1.0f;
            NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
        }
        lineRenderer.positionCount = path.corners.Length;
        lineRenderer.SetPositions(path.corners);
        if (path.corners.Length > 1)
        {
            Vector3 targetDirection = (path.corners[1] - _arrowDirection.transform.position).normalized;
            _arrowDirection.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }
}
