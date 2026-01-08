using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    private void Awake()
    {
        // Pastikan hanya ada satu musik menu
        if (FindObjectsOfType<MenuMusic>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void StopMusic()
    {
        GetComponent<AudioSource>().Stop();
        Destroy(gameObject);
    }
}
