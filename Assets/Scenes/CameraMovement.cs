
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Room Camera
    [SerializeField] private float speed;
    private float currentPosx;
    private Vector3 velocity = Vector3.zero;

    //Follow Player
    [SerializeField] private Transform player;

    private void Update()
    {
        //Room Camera
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.z),ref velocity, speed);
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosx, transform.position.y, transform.position.z), ref velocity, speed); 
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosx = _newRoom.position.x;
    }

}
