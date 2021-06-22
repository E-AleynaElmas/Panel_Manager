using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeyPanelData : PanelData
{
    string Name;
}

public class HeyPanel : Panel
{
    public PanelType Type;
    public Text NameText;
    HeyPanelData Data;
}
