using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicLightSFX : MonoBehaviour
{
    public Animator magicLightAnimator;

    public Light magicLight;
    // Start is called before the first frame update
    void Start()
    {
        magicLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnchantLight()
    {
        StartCoroutine(WaitforMagic());
        magicLightAnimator.Play("magicLightAnimation");
        GameManager.instance.magicClicked += 1;
    }

    IEnumerator WaitforMagic()
    {
        magicLight.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
    }

    public void NoMagic()
    {
        magicLight.gameObject.SetActive(false);
    }
}
