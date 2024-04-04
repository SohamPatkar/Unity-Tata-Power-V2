using UnityEngine;

[ExecuteInEditMode]
public class FollowScriptLocationIcon : MonoBehaviour
{
    [SerializeField]
    private GameObject _followCam;
    Vector3 target = Vector3.zero;

    void Update()
    {
        transform.LookAt(_followCam.transform);
        target = transform.localEulerAngles;
        target.x = 0;
        target.z = 0;
        transform.localEulerAngles = target;
    }
}
