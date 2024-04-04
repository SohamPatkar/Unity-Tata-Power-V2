using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        SceneManager.LoadScene("First_Scene");
        LocationManager.Instance.SetLevelName("");
        LocationManager.Instance.SetLocationName("");
    }
}
