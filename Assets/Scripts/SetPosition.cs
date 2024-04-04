using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARCore;

public class SetPosition : MonoBehaviour
{
    [SerializeField]
    public Transform positionObject;
    private string _locationName;
    private float initialYPosition;
    public ARSessionOrigin arOrigin;

    // Start is called before the first frame update
    void Start()
    {
        _locationName = LocationManager.Instance.GetLocationName();
        //positionObject = GameObject.Find("LiftFirstFloor").transform;
        positionObject = GameObject.Find(_locationName).transform;
        Quaternion objectRotation = positionObject.localRotation;
        transform.rotation = objectRotation;
        transform.position = new Vector3(positionObject.position.x, transform.position.y, positionObject.position.z);
        initialYPosition = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(positionObject.transform.position.x, initialYPosition, positionObject.transform.position.z);
    }
}
