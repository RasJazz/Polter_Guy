using System.Collections;
using UnityEngine;

public class FamilyMember : MonoBehaviour
{
    [SerializeField] private int _maxSanity;
    private int _currentSanity;
    [SerializeField] private SanityBar _sanityBar;
    [SerializeField] private float _sightRange = 10f; // Range to detect the player
    [SerializeField] private float _sightDuration = 3f; // Time player must be seen
    [SerializeField] private int _sanityIncreaseValue = 5;
    
    private Transform _player;
    private bool _isPlayerInVision = false;
    
    void Start()
    {
        _currentSanity = _maxSanity;
        _sanityBar.SetMaxSanity(_maxSanity);
        _player = GameObject.FindGameObjectWithTag("Player")?.transform; // Assumes the player has the tag "Player"
        Debug.Log(_player);
    }

    void Update()
    {
        if (_player != null)
        {
            DetectPlayer();
        }
    }

    private void DetectPlayer()
    {
        // Check if the player is within sight range
        float distanceToPlayer = Vector3.Distance(new Vector3(transform.position.x, transform.position.y), new Vector2(_player.position.x, _player.position.y));
        if (distanceToPlayer <= _sightRange)
        {
            // Cast a ray to check for line of sight
            Vector3 directionToPlayer = _player.position - transform.position;
            RaycastHit hit;

            Debug.DrawLine(transform.position, transform.position + (Vector3)directionToPlayer.normalized * _sightRange, Color.red);
            
            if (Physics.Raycast(transform.position, directionToPlayer.normalized, out hit, _sightRange))
            {
                // Raycast line debug
                Debug.DrawLine(transform.position, hit.point, Color.red);
                
                // If player is in vision, check for x seconds to see how long player is in sight
                if (hit.collider.CompareTag("Player") && !_isPlayerInVision)
                {
                    _isPlayerInVision = true;
                    StartCoroutine(IncreaseSanityOverTime());
                }
                else // Else, stop tracking player
                {
                    _isPlayerInVision = false;
                    StopCoroutine(IncreaseSanityOverTime());
                }
            }
            else
            {
                // Player is not in line of sight
                if (_isPlayerInVision)
                {
                    _isPlayerInVision = false;
                    StopCoroutine(IncreaseSanityOverTime());
                }
            }
        }
        else
        {
            // Player is out of sight range
            if (_isPlayerInVision)
            {
                _isPlayerInVision = false;
                StopCoroutine(IncreaseSanityOverTime());
            }
        }
    }

    private IEnumerator IncreaseSanityOverTime()
    {
        float elapsedTime = 0f;

        while (elapsedTime < _sightDuration)
        {
            if (_isPlayerInVision)
            {
                elapsedTime += Time.deltaTime;
            }
            yield return null;
        }
        
        Debug.Log(elapsedTime);
        _sanityBar.SetSanity(_sanityIncreaseValue);
    }
    
}
