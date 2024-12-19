using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowStats : MonoBehaviour
{
    public TextMeshProUGUI statText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayStats()
    {
        statText.text = "Thunder cues called: " + GameManager.instance.thunderClicked
                                           + " \nLightning cues called: " + GameManager.instance.lightningClicked
                                           + " \nWave cues called: " + GameManager.instance.waveClicked
                                           + " \nCalm wash cues called: " + GameManager.instance.calmClicked
                                           + " \nMagic light cues called: " + GameManager.instance.magicClicked;
    }
}
