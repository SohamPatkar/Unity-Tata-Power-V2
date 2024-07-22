using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class LocationsArray : MonoBehaviour
{
    [SerializeField] public GameObject[] _locations;
    public string _locationName;
    [SerializeField] private GameObject _followCam;
    void Start()
    {
        gameObject.GetComponent<NavMeshAgent>().enabled = false;
        _locationName = LocationManager.Instance.GetLocationName();
        foreach (GameObject item in _locations)
        {
            if (item.name == _locationName)
            {
                transform.position = item.transform.position;
                gameObject.GetComponent<NavMeshAgent>().enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_followCam.transform.position.x, transform.position.y, _followCam.transform.position.z);
    }
}
