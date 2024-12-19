using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSFX : MonoBehaviour
{
    public Animator lightningAnimator;
    public Light lightningLight;
    
    // Start is called before the first frame update
    void Start()
    {
        lightningLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightningFlash()
    {
        StartCoroutine(WaitforLightningStart());
        lightningAnimator.Play("lightningAnimation");
        GameManager.instance.lightningClicked += 1;
        StartCoroutine(WaitforLightningEnd());

    }

    IEnumerator WaitforLightningStart()
    {
        lightningLight.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.4f);
    }

    IEnumerator WaitforLightningEnd()
    {
        yield return new WaitForSeconds(2f);
        lightningLight.gameObject.SetActive(false);
    }
}
