using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LocationSelection : MonoBehaviour
{
    public LevelStorage levelStorage;

    [SerializeField]
    private Text _locationInfo;
    public void TdOffice()
    {
        LocationManager.Instance.SetLocationName("T&DOffice");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "T&D Office selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void PSCC()
    {
        LocationManager.Instance.SetLocationName("PSCCCenter");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "PSCC Center selected!";
        SceneManager.LoadScene("FirstFloor");
    }
    public void ConferenceRoom()
    {
        LocationManager.Instance.SetLocationName("ConferenceRoom");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Conference Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void PacificTraining()
    {
        LocationManager.Instance.SetLocationName("PacificTraining");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Pacific Training selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void EntranceLobby()
    {
        LocationManager.Instance.SetLocationName("EntranceLobby");
        LocationManager.Instance.SetFloor("SecondFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Entrance Lobby selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void MainControlRoom()
    {
        LocationManager.Instance.SetLocationName("MainControlRoom");
        LocationManager.Instance.SetFloor("SecondFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Main Control Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void ControlRoom()
    {
        LocationManager.Instance.SetLocationName("ControlRoom");
        LocationManager.Instance.SetFloor("SecondFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Control Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void ExitFirstFloor()
    {
        LocationManager.Instance.SetLocationName("LiftFirstFloor");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Exit selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void Washroom()
    {
        LocationManager.Instance.SetLocationName("Washroom");
        LocationManager.Instance.SetFloor("FirstFloor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Washroom selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void ServerRoom()
    {
        LocationManager.Instance.SetLocationName("ServerRoom");
        LocationManager.Instance.SetFloor("SecondFLoor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "Server Room selected!";
        SceneManager.LoadScene("FirstFloor");
    }

    public void CCRA()
    {
        LocationManager.Instance.SetLocationName("CCRA");
        LocationManager.Instance.SetFloor("SecondFLoor");
        levelStorage._selectedlevelname = LocationManager.Instance.GetFloor();
        _locationInfo.text = "CCRA selected!";
        SceneManager.LoadScene("FirstFloor");
    }
}
