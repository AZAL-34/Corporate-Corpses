using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool locked;
    public GameObject player;
    public Vector3 lockPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (locked)
        {
            transform.position = lockPosition;
        }
        else
        {
            transform.position = player.transform.position + new Vector3(0, 0, -10);
        }
        transform.rotation = player.transform.rotation;
    }
}
