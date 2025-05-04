using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPosition : MonoBehaviour
{
    [SerializeField] Transform[] spawnPositions;
    [SerializeField] Transform player;
    [SerializeField] Transform camera;

    void Start()
    {
        PickRandomPosition();
    }

    void PickRandomPosition()
    {
        Transform spawnPosition = spawnPositions[Random.Range(0, 2)];
        //player.position = spawnPosition.position;
        camera.position = spawnPosition.position;
        //player.rotation = spawnPosition.rotation;
        camera.rotation = spawnPosition.rotation;
    }
}
