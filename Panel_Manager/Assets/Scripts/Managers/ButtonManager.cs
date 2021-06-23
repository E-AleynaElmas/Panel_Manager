using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Singleton class
public class ButtonManager : Singleton<ButtonManager>
{
    //observer pattern
    public delegate void CloseListener();

    public List<Button> buttonQueue = new List<Button>();

    private void OnEnable()
    {
        HidePanelButton.CloseDetection += SetActive;
    }

    private void OnDisable()
    {
        HidePanelButton.CloseDetection -= SetActive;
    }

    public void SetActive()
    {
        if (buttonQueue.Count > 0)
        {
            buttonQueue[buttonQueue.Count - 1].interactable = true;
            buttonQueue.RemoveAt(buttonQueue.Count - 1);
        }
    }

    public void AddButton(Button button)
    {
        buttonQueue.Add(button);
    }
}
