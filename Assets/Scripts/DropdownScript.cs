using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DropdownScript : MonoBehaviour
{
    public int value;
    public Dropdown m_dropdown;
    
    private void Update()
    {
        value = HandleInputData(m_dropdown.value);
        if (value == 0)
        {
            LocationManager.Instance.SetLevelName("Ground_Floor");
        }
        else if (value == 1)
        {
            LocationManager.Instance.SetLevelName("FirstFloor");
        }
        else if (value == 2)
        {
            LocationManager.Instance.SetLevelName("Second_Floor");
        }
        else if (value == 3)
        {
            LocationManager.Instance.SetLevelName("SampleScene");
        }
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Template_QR");
    }

    public int HandleInputData(int value)
    {
        return value;
    }
}
