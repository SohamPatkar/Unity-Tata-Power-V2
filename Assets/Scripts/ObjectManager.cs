using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;


public class ObjectManager : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] gameObjects;
    public Navmeshes _mesh;
    private void Awake()
    {
        _mesh = GameObject.Find("Indicator").GetComponent<Navmeshes>();
    }
    // Start is called before the first frame update
    void Start()
    {
        PopulateDropdown();
    }

    private void Update()
    {
        ActivateSelectedObject();
    }

    private void ActivateSelectedObject()
    {
        int selectedIndex = dropdown.value;
        
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i == selectedIndex)
            {
                gameObjects[i].SetActive(true);
                _mesh.target = gameObjects[i].transform ;
            }
            else
            {
                gameObjects[i].SetActive(false);
            }
        }
    }

    private void PopulateDropdown()
    {
        dropdown.ClearOptions();
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
        
        foreach ( GameObject obj in gameObjects)
        {
            Dropdown.OptionData option = new Dropdown.OptionData(obj.name);
            options.Add(option);
        }
        
        dropdown.AddOptions(options);
    }   
}
