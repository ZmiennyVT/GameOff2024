using UnityEngine;
using static interaction;

public class InteractiveObject : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log($"Open");
        // Dodaj tutaj logik� interakcji, np. otwieranie drzwi, podnoszenie przedmiotu
    }
}
