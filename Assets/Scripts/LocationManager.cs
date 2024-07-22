using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    private static LocationManager _instance;
    public static LocationManager Instance { get { return _instance; } }

    private Location locationObject = new Location();

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public string GetFloor()
    {
        return locationObject._floor.ToString();
    }

    public void SetFloor(string floor)
    {
        locationObject._floor = floor;
    }

    public string GetLevelName()
    {
        return locationObject._Level_Name.ToString();
    }

    public void SetLevelName(string name)
    {
        locationObject._Level_Name = name;
    }

    public string GetLocationName()
    {
        return locationObject._Location_Name.ToString();
    }

    public void SetLocationName(string name)
    {
        locationObject._Location_Name = name;
    }
}
