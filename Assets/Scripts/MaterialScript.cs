using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARCore;

public class MaterialScript : MonoBehaviour
{
    [SerializeField] public Material m_Material;
    public GameObject _arSessionObject;
    private ARSession _arSession;
    private float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        _arSession = _arSessionObject.GetComponent<ARSession>();
        offsetX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        offsetX -= 1 * Time.deltaTime;
        m_Material.mainTextureOffset = new Vector2(offsetX, 0);
    }

    public void OnClickLocation()
    {
        _arSession.Reset();
        SceneManager.LoadScene("LocationSelect");
    }
}
