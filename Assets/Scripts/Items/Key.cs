using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PlayerInteractable
{
    public void Start()
    {
        OnPlayerEnter.AddListener((var) => { UIManager.instance.SetInteractionModalState(true); });
        OnPlayerExit.AddListener((var) => { UIManager.instance.SetInteractionModalState(false); });
    }
}
