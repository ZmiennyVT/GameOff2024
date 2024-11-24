using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("Modals")]
    public TextMeshProUGUI interactionModal;

    public GameObject eq;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            eq.SetActive(!eq.active);
        }
    }

    public void SetInteractionModalState(bool state)
    {
        if(interactionModal != null)
        {
            interactionModal.gameObject.SetActive(state);
        }
    }


    

}
