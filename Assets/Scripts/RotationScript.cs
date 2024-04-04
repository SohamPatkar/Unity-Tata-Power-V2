using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public GameObject _arrow;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation_A = _arrow.transform.rotation;
        transform.rotation = rotation_A;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
