using UnityEngine;
using static interaction;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance = 3f; // Maksymalna odleg³oœæ interakcji
    public LayerMask interactableLayer;   // Warstwa dla interaktywnych obiektów

    private Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckForInteractable();
        }
    }

    void CheckForInteractable()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance, interactableLayer))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
