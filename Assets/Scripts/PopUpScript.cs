using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    [SerializeField]
    public LevelStorage levelstorageObject;
    public string _levelselectname;
    public Text _popupText;
    void Start()
    {
        PopupData();
    }

    void PopupData()
    {
        _levelselectname = levelstorageObject._selectedlevelname;
        if (_levelselectname == "FirstFloor")
        {
            Debug.Log("FirstFloorWorks");
            _popupText.text = "You can Select Exit 2!";
        }
        else if (_levelselectname == "SecondFloor")
        {
            _popupText.text = "You can Select Exit 3!";
        }
    }
}
