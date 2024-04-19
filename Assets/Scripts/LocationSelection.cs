using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LocationSelection : MonoBehaviour
{
    [SerializeField]
    private Text _locationInfo;
    public void TdOffice()
    {
        LocationManager.Instance.SetLocationName("T&DOffice");
        _locationInfo.text = "T&D Office selected!";
        SceneManager.LoadScene("FirstFloor");
        Debug.Log("Is Pressed!");
    }

    public void PSCC()
    {
        LocationManager.Instance.SetLocationName("PSCCCenter");
        _locationInfo.text = "PSCC Center selected!";
        SceneManager.LoadScene("FirstFloor");
    }
    public void ConferenceRoom()
    {
        LocationManager.Instance.SetLocationName("ConferenceRoom");
        _locationInfo.text = "Conference Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void PacificTraining()
    {
        LocationManager.Instance.SetLocationName("PacificTraining");
        _locationInfo.text = "Pacific Training selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void EntranceLobby()
    {
        LocationManager.Instance.SetLocationName("EntranceLobby");
        _locationInfo.text = "Entrance Lobby selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void MainControlRoom()
    {
        LocationManager.Instance.SetLocationName("MainControlRoom");
        _locationInfo.text = "Main Control Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void ControlRoom()
    {
        LocationManager.Instance.SetLocationName("ControlRoom");
        _locationInfo.text = "Control Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void ServerRoom()
    {
        LocationManager.Instance.SetLocationName("ServerRoom");
        _locationInfo.text = "Server Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void CCRA()
    {
        LocationManager.Instance.SetLocationName("CCRA");
        _locationInfo.text = "CCRA selected!";
        SceneManager.LoadScene("FirstFloor");
    }
}
