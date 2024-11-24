using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class PlayerInteractable : MonoBehaviour
{
    [Header("Interaction Events")]
    public UnityEvent<Collider> OnPlayerEnter;
    public UnityEvent<Collider> OnPlayerExit;
    public UnityEvent<Collider> OnPlayerStay;

    /// <summary>
    /// Called when a collider enters the trigger.
    /// </summary>
    /// <param name="other">The collider that entered.</param>
    public virtual void OnTriggerEnter(Collider other)
    {
        if (IsPlayer(other))
        {
            OnPlayerEnter?.Invoke(other);
        }
    }

    /// <summary>
    /// Called when a collider exits the trigger.
    /// </summary>
    /// <param name="other">The collider that exited.</param>
    public virtual void OnTriggerExit(Collider other)
    {
        if (IsPlayer(other))
        {
            OnPlayerExit?.Invoke(other);
        }
    }

    /// <summary>
    /// Called when a collider stays within the trigger.
    /// </summary>
    /// <param name="other">The collider staying in the trigger.</param>
    public virtual void OnTriggerStay(Collider other)
    {
        if (IsPlayer(other))
        {
            OnPlayerStay?.Invoke(other);
        }
    }

    /// <summary>
    /// Checks if the collider belongs to the player.
    /// Override this method if you need custom logic to determine player identity.
    /// </summary>
    /// <param name="other">The collider to check.</param>
    /// <returns>True if the collider is the player, otherwise false.</returns>
    protected virtual bool IsPlayer(Collider other)
    {
        return other.CompareTag("Player");
    }
}
