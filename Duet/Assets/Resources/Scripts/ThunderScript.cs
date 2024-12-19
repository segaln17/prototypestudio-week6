using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderScript : MonoBehaviour
{
    public AudioSource thunderHolder;

    public AudioClip thunder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thunderclap()
    {
        thunderHolder.PlayOneShot(thunder);
        GameManager.instance.thunderClicked += 1;
    }
}
