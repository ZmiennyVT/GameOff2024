using UnityEngine;
using static interaction;

public class InteractiveObject : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log($"Open");
        // Dodaj tutaj logikê interakcji, np. otwieranie drzwi, podnoszenie przedmiotu
    }
}
