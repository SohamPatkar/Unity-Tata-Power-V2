using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Info;
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject objectHit = hit.collider.gameObject;
            foreach (GameObject item in Info)
            {
                if (item.name == "InfoScreen_" + objectHit.name)
                {
                    item.SetActive(true);
                    item.transform.localScale = Vector3.Lerp(item.transform.localScale, Vector3.one, Time.deltaTime * 0.5f);
                }
                else
                {
                    item.SetActive(false);
                    item.transform.localScale = Vector3.zero;
                }
            }
        }   
    }
}
