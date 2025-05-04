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

    /*void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }*/

    void PickRandomPosition()
    {
        int newPos = Random.Range(0, 2);
        Transform spawnPosition = spawnPositions[0];
        Debug.Log(newPos+1);
        //player.position = spawnPosition.position;
        camera.position = spawnPosition.position;
        //player.rotation = spawnPosition.rotation;
        camera.rotation = spawnPosition.rotation;
    }
}
