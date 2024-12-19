using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmLightSFX : MonoBehaviour
{
    public Animator calmLightAnimator1;
    public Animator calmLightAnimator2;

    public Light calmLight1;

    public Light calmLight2;
    // Start is called before the first frame update
    void Start()
    {
        calmLight1.gameObject.SetActive(false);
        calmLight2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalmLightWash()
    {
        StartCoroutine(WaitforWash());
        calmLightAnimator1.Play("calmLightAnimation");
        calmLightAnimator2.Play("calmLightAnimation");
        GameManager.instance.calmClicked += 1;
    }

    IEnumerator WaitforWash()
    {
        calmLight1.gameObject.SetActive(true);
        calmLight2.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
    }

    public void NoCalmLight()
    {
        calmLight1.gameObject.SetActive(false);
        calmLight2.gameObject.SetActive(false);
    }
}
