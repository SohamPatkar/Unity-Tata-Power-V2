using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaterialScript : MonoBehaviour
{
    [SerializeField]
    public Material m_Material;
    private float offsetX;
    // Start is called before the first frame update
    void Start()
    {
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
        SceneManager.LoadScene("LocationSelect");
    }
}
