using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeyPanelData : PanelData
{
    public string Name;
}

public class HeyPanel : Panel
{
    public PanelType Type;
    public Text NameText;
    HeyPanelData Data;

    public override void ShowPanel(PanelData data)
    {
        base.ShowPanel(data);
        var _data = data as HeyPanelData;
        Data = _data;
        NameText.text = Data.Name;
    }
}
