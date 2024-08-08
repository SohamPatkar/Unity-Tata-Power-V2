using UnityEngine;
using UnityEngine.UI;


public class TriggerforPopup : MonoBehaviour
{
    [SerializeField] public Text text;
    [SerializeField] public GameObject _panel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IndicatorGroundFloor"))
        {
            _panel.SetActive(true);
            if (this.gameObject.transform.position.y > 0)
            {
                text.text = "You can choose EntranceGroundFloor Option";
            }
            else if (this.gameObject.transform.position.y < 0 && this.transform.position.y > -3)
            {
                text.text = "You can choose EntranceGroundFloor Option";
            }
            else if (this.gameObject.transform.position.y > -8)
            {
                text.text = "You can choose FrontEntrance Option";
            }
            Debug.Log("You have entered the collision!");
        }
    }
}
