using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu
(fileName = "NewPage",
    menuName = "NewPage", order = 0)]

public class Script_ScriptableObject : ScriptableObject
{
    public TextMeshProUGUI pageText;
    public Image cueNote;
}
