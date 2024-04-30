using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject prefab; // Assign your prefab in the Unity Editor
    public Transform spawnPosition;
    // Function to instantiate the prefab at a given position
    public void Spawn()
    {
        if (prefab != null)
        {
            Instantiate(prefab, spawnPosition.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Prefab is not assigned!");
        }
    }
}