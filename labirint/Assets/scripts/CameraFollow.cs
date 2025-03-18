using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private Vector3 _cameraPosition;

    [SerializeField] private float _cameraHeight;

    public void Update()
    {
        _cameraPosition = new Vector3(_player.position.x, 
            _player.position.y + _cameraHeight, 
            _player.position.z);
        
        transform.position = _cameraPosition;
    }
}
