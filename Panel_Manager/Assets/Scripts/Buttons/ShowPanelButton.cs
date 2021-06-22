using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanelButton : MonoBehaviour
{
    public PanelType type;
    public PanelData data;

    //sınıftan bağımsız tüm butonlar arasındaki current button'ı tutar.
    public static ShowPanelButton currentButton;

    private Button button;
    private PanelManager panelManager;

    private void Start()
    {
        panelManager = PanelManager.Instance;
        button = GetComponent<Button>();
    }

    public void DoShowPanel()
    {
        panelManager.Show(type);
        SetActivity();
    }

    public void SetActive()
    {
        currentButton.button.interactable = true;
    }

    private void SetActivity()
    {
        if (currentButton == null)
        {
            currentButton = this;
        }
        else
        {
            currentButton.button.interactable = true;
        }
        button.interactable = false;
        currentButton = this;
    }
}
