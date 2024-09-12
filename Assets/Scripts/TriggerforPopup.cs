using UnityEngine;
using UnityEngine.UI;


public class TriggerforPopup : MonoBehaviour
{
    [SerializeField] public GameObject _messageBoxText, _secondFloorText;
    [SerializeField] public GameObject _messageBox;
    [SerializeField] public GameObject _alternateExitPopup;

    void Start()
    {
        _messageBoxText.SetActive(false);
        _secondFloorText.SetActive(false);
        _alternateExitPopup.SetActive(false);
        _messageBox.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IndicatorGroundFloor"))
        {
            if (this.gameObject.transform.position.y > 0)
            {
                _messageBoxText.SetActive(false);
                _secondFloorText.SetActive(true);
                _messageBox.SetActive(true);
            }
            else if (this.gameObject.transform.position.y < 0 && this.transform.position.y > -3)
            {
                _secondFloorText.SetActive(false);
                _messageBoxText.SetActive(true);
                _messageBox.SetActive(true);
            }
            else if (this.gameObject.transform.position.y > -8)
            {
                _alternateExitPopup.SetActive(true);
                LeanTween.alpha(_alternateExitPopup.GetComponent<RectTransform>(), 1f, 0.5f);
            }
            Debug.Log("You have entered the collision!");
        }
    }

    public void Disable()
    {
        _alternateExitPopup.SetActive(false);
        _messageBoxText.SetActive(false);
        _secondFloorText.SetActive(false);
    }

    public void OnPressExit()
    {
        _messageBox.SetActive(false);
    }
}
