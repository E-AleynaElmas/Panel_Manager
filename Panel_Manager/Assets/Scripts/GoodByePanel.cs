using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodByePanelData : PanelData
{
    string Name;
}

public class GoodByePanel : Panel
{
    public PanelType Type;
    public Text NameText;
    GoodByePanelData Data;
}
