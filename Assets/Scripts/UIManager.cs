using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text pinesText;

    void Start()
    {
        pinesText = GameObject.Find("PinesText").GetComponent<Text>();
    }

    void Update()
    {
        pinesText.text = "Pines down: " + PineVerifier.pinesDown.ToString();
    }
}
