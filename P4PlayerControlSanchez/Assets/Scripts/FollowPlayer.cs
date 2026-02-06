using UnityEngine;

public class Camera : MonoBehaviour
{
    public class GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position; + new Vector3(0, 5, -7);
        
    }
}