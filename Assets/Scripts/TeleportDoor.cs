using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoor : MonoBehaviour
{
    [SerializeField] int doorIndex;
    [SerializeField] bool vr;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if(vr)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
