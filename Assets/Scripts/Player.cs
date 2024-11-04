using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _playerGo;
    [SerializeField] private float speed;
    
    //private BoxCollider2D _playerCollider;
    private InputComponent _input;
    private PhysicsComponent _physics;

    private void Start()
    {
        _input = GetComponent<InputComponent>();
        _physics = GetComponent<PhysicsComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputDirection = _input.UpdateInput(); // Player input
        _physics.MoveEntity(inputDirection, speed); // Player Physics
        // Pass in movement direction to Sprite
    }
}
