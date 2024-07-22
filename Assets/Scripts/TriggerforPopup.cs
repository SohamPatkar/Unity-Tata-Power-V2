using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TriggerforPopup : MonoBehaviour
{
    [SerializeField] public Text text;
    [SerializeField] public GameObject _panel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IndicatorGroundFloor"))
        {
            _panel.SetActive(true);
            text.text = "You can also choose another way!";
            Debug.Log("You have entered the collision!");
        }
    }
}
