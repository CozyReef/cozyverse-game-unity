using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySize : MonoBehaviour
{

    public Text Size;
    public GameManager _GameManager;

    // Update is called once per frame
    void Update()
    {

        Size.text = "/ " + (_GameManager.playerCargoSize).ToString();
        
    }
}
