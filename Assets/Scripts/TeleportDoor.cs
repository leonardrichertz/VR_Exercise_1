using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoor : MonoBehaviour
{
    [SerializeField] int doorIndex;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
