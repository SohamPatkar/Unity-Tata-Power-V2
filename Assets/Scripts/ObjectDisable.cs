using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ObjectDisable : MonoBehaviour
{
    public GameObject[] obj;
    public XROrigin _xrOriginPosition;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in obj)
        {
            if (_xrOriginPosition.transform.position.y < -3.16f)
            {
                if (go.CompareTag("IndicatorGroundFloor"))
                {
                    go.SetActive(true);
                }
            }
            else if (_xrOriginPosition.transform.position.y > -3.16f)
            {
                if (go.CompareTag("IndicatorFirstFloor"))
                {
                    go.SetActive(true);
                }
            }
        }

    }
}
