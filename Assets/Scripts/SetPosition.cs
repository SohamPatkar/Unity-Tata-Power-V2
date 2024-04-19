using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARCore;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SetPosition : MonoBehaviour
{
    [SerializeField]
    public Transform positionObject;
    private string _locationName;
    private float initialYPosition;
    public Text _textSuggestion;
    private float _timer;
    public GameObject _panel;

    // Start is called before the first frame update
    void Start()
    {
        LocationSet();
        ClosestHydrant();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += 1 * Time.deltaTime;
        transform.position = new Vector3(positionObject.transform.position.x, initialYPosition, positionObject.transform.position.z);
        if(_timer >= 10)
        {
            _panel.SetActive(false);
        }
        Debug.Log(_timer);
    }

    void LocationSet()
    {
        _locationName = LocationManager.Instance.GetLocationName();
        //positionObject = GameObject.Find("LiftFirstFloor").transform;
        positionObject = GameObject.Find(_locationName).transform;
        Quaternion objectRotation = positionObject.rotation;
        transform.rotation = objectRotation;
        transform.position = new Vector3(positionObject.position.x, positionObject.position.y, positionObject.position.z);
        initialYPosition = transform.localPosition.y;
    }

    void ClosestHydrant()
    {
        switch (_locationName)
        {
            case "PSCCCenter":
                _textSuggestion.text = "Select Fire Hydrant TWO";
                break;

            case "ConferenceRoom":
                _textSuggestion.text = "Select Fire Hydrant Three";
                break;

            case "PacificTraining":
                _textSuggestion.text = "Select Fire Hydrant One";
                break;

            case "T&DOffice":
                _textSuggestion.text = "Select Fire Hydrant One";
                break;
        }
    }
}
