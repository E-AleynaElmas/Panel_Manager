using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelButton : MonoBehaviour
{
    public PanelType type;
    public PanelData data;

    private PanelManager panelManager;

    private void Start()
    {
        panelManager = PanelManager.Instance;
    }

    public void DoShowPanel()
    {
        panelManager.Show(type);
    }
}
