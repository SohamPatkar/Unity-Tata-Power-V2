using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
// using UnityEngine.XR.ARCore;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SetPosition : MonoBehaviour
{
    [SerializeField]
    public Transform positionObject;
    private string _locationName;
    private float initialYPosition;
    public Text _textSuggestion;
    // private float _timer;
    public GameObject _panel;
    public float _clickCounter;
    // Start is called before the first frame update
    void Start()
    {
        LocationSet();
        ClosestHydrant();
        _clickCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // _timer += 1 * Time.deltaTime;
        transform.position = new Vector3(positionObject.transform.position.x, initialYPosition, positionObject.transform.position.z);
        // if (_timer >= 10)
        // {
        //     _panel.SetActive(false);
        // }
        // Debug.Log(_timer);
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
                _textSuggestion.text = "(You can select 'Fire Extinguisher Two' from the drop-down, as it’s the nearest.)";
                break;

            case "ConferenceRoom":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Three' from the drop-down, as it’s the nearest.)";
                break;

            case "PacificTraining":
                _textSuggestion.text = "(You can select 'Fire Extinguisher One' from the drop-down, as it’s the nearest.)";
                break;

            case "T&DOffice":
                _textSuggestion.text = "(You can select 'Fire Extinguisher One' from the drop-down, as it’s the nearest.)";
                break;

            case "MainControlRoom":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Five' from the drop-down, as it’s the nearest.)";
                break;

            case "EntranceLobby":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Four' from the drop-down, as it’s the nearest.)";
                break;

            case "CCRA":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Four' from the drop-down, as it’s the nearest.)";
                break;

            case "ServerRoom":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Nine' from the drop-down, as it’s the nearest.)";
                break;

            case "ControlRoom":
                _textSuggestion.text = "(You can select 'Fire Extinguisher Nine' from the drop-down, as it’s the nearest.)";
                break;
        }
    }

    public void OnclickAlternate()
    {
        ++_clickCounter;
        _panel.SetActive(true);
        LeanTween.moveX(_panel.GetComponent<RectTransform>(), 447f, 0.5f);
        if (_clickCounter > 1)
        {
            LeanTween.moveX(_panel.GetComponent<RectTransform>(), -1500, 0.5f);
            // _panel.SetActive(false);
            _clickCounter = 0;
        }
    }
}
