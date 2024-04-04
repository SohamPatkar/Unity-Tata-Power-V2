using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationsArray : MonoBehaviour
{
    [SerializeField]
    public GameObject[] _locations;
    public string _locationName;
    [SerializeField]
    private GameObject _followCam;
    void Start()
    {
        _locationName = LocationManager.Instance.GetLocationName();
        foreach (GameObject item in _locations)
        {
            if(item.name == _locationName)
            {
                gameObject.transform.position = new Vector3(item.transform.position.x, gameObject.transform.position.y, item.transform.position.z);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_followCam.transform.position.x, transform.position.y, _followCam.transform.position.z);
    }
}
