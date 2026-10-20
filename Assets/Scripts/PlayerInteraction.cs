using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        HandleContact(other.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        HandleContact(collision.gameObject);
    }

    private void HandleContact(GameObject touchedObject)
    {
        if (touchedObject.CompareTag("Target"))
        {
            string message = "Target tersentuh. Praktikum berhasil!";
            if (StatusNotifier.Instance != null)
            {
                StatusNotifier.Instance.ShowStatus(message);
            }
            touchedObject.SetActive(false);
        }
        else if (touchedObject.CompareTag("Obstacle"))
        {
            string message = "Obstacle tersentuh: " + touchedObject.name;
            if (StatusNotifier.Instance != null)
            {
                StatusNotifier.Instance.ShowStatus(message);
            }
        }
    }
}