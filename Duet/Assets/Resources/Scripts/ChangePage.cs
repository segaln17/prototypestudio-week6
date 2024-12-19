using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangePage : MonoBehaviour
{
    public TextMeshProUGUI linesOnPage;

    public Script_ScriptableObject lines;

    public TextMeshProUGUI page1;

    public TextMeshProUGUI page2;

    public TextMeshProUGUI page3;

    public TextMeshProUGUI page4;

    public TextMeshProUGUI page5;
    
    public TextMeshProUGUI page6;

    public List<TextMeshProUGUI> pageList = new List<TextMeshProUGUI>();
    
    // Start is called before the first frame update
    void Start()
    {
        //pageList.Add(page1);
        //page 1 is already loaded up
        //TODO: also load in cues?
        pageList.Add(page2);
        pageList.Add(page3);
        pageList.Add(page4);
        pageList.Add(page5);
        pageList.Add(page6);
        
        page2.gameObject.SetActive(false);
        page3.gameObject.SetActive(false);
        page4.gameObject.SetActive(false);
        page5.gameObject.SetActive(false);
        page6.gameObject.SetActive(false);

        linesOnPage = page1;
        linesOnPage.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnPage()
    {
        if (pageList.Count != 0)
        {
            StartCoroutine(PageTurning());
            linesOnPage.gameObject.SetActive(false);
            linesOnPage = pageList[0];
            //linesOnPage.text = lines.pageText.text;
            linesOnPage.gameObject.SetActive(true);
            linesOnPage.text = pageList[0].text;
            pageList.RemoveAt(0);
            //Debug.Log(pageList);
        }
        else
        {
            return;
        }
        
    }

    IEnumerator PageTurning()
    {
        yield return new WaitForSeconds(1f);
        //Add anim or page turning sound
        //TurnPage();
    }
    
}
