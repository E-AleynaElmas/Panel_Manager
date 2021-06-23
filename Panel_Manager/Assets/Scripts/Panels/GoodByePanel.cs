using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodByePanelData : PanelData
{
    public string Name;
}

public class GoodByePanel : Panel
{
    public PanelType Type;
    public Text NameText;
    GoodByePanelData Data;

    public override void ShowPanel(PanelData data)
    {
        base.ShowPanel(data);
        var _data = data as GoodByePanelData;
        Data = _data;
        NameText.text = Data.Name;
    }
}
