using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessageReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void SetLevelName(string levelName)
    {
        LocationManager.Instance.SetLevelName(levelName);
    }

    public void SetPosition(string position)
    {
        LocationManager.Instance.SetLocationName(position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
