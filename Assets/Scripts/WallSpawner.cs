using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wallPrefab;
    void Start()
    {
        InvokeRepeating("CreateWall", 1.0f, 2.0f);
    }

    void Update()
    {
        if (!PlayerMovement.alive)
        {
            CancelInvoke("CreateWall");
        }
    }

    void CreateWall()
    {
        var instance = Instantiate(wallPrefab);
    }
}
