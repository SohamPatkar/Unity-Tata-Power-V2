using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScript : MonoBehaviour
{
    public GameObject[] ScreenArray;
  
    // Start is called before the first frame update
    public void OnLook(GameObject item)
    {
        foreach(GameObject info in ScreenArray)
        {
            if(item.name == info.name)
            {
                item.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, Time.deltaTime * 2f);
            }
        }
    }
}
