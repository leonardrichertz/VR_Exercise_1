using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoorInterior : MonoBehaviour
{
    [SerializeField] int doorIndex;
    [SerializeField] bool vr;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if(vr)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
