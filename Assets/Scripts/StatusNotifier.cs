using UnityEngine;
using UnityEngine.UI;
using TMPro; // Jika menggunakan TextMeshPro

public class StatusNotifier : MonoBehaviour
{
    public static StatusNotifier Instance;

    // Drag UI Text dari Hierarchy ke sini di Inspector
    public TextMeshProUGUI statusText; // atau gunakan 'Text' jika tidak pakai TMP

    private float displayTimer = 0f;
    private float displayDuration = 2f; // Pesan hilang setelah 2 detik

    void Awake()
    {
        Instance = this;
        if (statusText != null)
        {
            statusText.text = ""; // Kosongkan saat mulai
        }
    }

    void Update()
    {
        if (displayTimer > 0)
        {
            displayTimer -= Time.deltaTime;
            if (displayTimer <= 0 && statusText != null)
            {
                statusText.text = ""; // Hilangkan pesan setelah waktu habis
            }
        }
    }

    public void ShowStatus(string message)
    {
        if (statusText != null)
        {
            statusText.text = message;
            displayTimer = displayDuration;
        }
        Debug.Log(message); // Tetap tampilkan di Console juga
    }
}