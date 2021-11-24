using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;
    void Start()
    {
        InvokeRepeating("CreateWalls", 1.0f, 2.0f);
    }

    void CreateWalls()
    {
        var instance = Instantiate(wallPrefab);
    }
}
