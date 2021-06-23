using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodByePanelButton : MonoBehaviour
{
    private PanelType type;
    private Button button;
    private Text nameText;
    private string name;
    private GoodByePanelData data;
    private PanelManager panelManager;

    private void Start()
    {
        panelManager = PanelManager.Instance;
        nameText = GetComponentInChildren<Text>();
        name = nameText.text;
        
        type = PanelType.GoodByePanel;

        button = GetComponent<Button>();
        button.onClick.AddListener(DoShowPanel);

        data = new GoodByePanelData();
        data.Name = name;
    }

    public void DoShowPanel()
    {
        panelManager.Show(type, data);
        ButtonManager.Instance.AddButton(button);
        SetDeActive();
    }

    public void SetDeActive()
    {
        button.interactable = false;
    }
}
