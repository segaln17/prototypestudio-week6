using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public AudioSource waveSource;

    public AudioClip waveClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WaveHit()
    {
        waveSource.PlayOneShot(waveClip);
        GameManager.instance.waveClicked += 1;
    }
}
