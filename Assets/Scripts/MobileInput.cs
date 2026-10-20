using UnityEngine;

public class MobileInput : MonoBehaviour
{
    // Variabel statis agar bisa dibaca PlayerMovement dari mana saja
    public static float horizontal = 0f;
    public static float vertical = 0f;

    // Metode yang dipanggil tombol UI saat disentuh
    public void SetHorizontal(float value) { horizontal = value; }
    public void SetVertical(float value) { vertical = value; }
}