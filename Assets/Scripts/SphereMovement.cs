using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SphereMovement : MonoBehaviour, IPointerClickHandler
{
    [SerializeField, Range(0, 5)] private float _distanceTarget = 5f;
    [SerializeField] private Rigidbody _rigidbody;

    private float _offset = 0.1f;
    private bool _isForward = true;

    public void OnPointerClick(PointerEventData eventData)
    {
        print(eventData);
        StartCoroutine(MovementDelay());
    }

    private void OnDisable()
    {
        StopCoroutine(MovementDelay());
    }

    private IEnumerator MovementDelay()
    {
        while (true)
        {
            var waitForSeconds = new WaitForSeconds(0.01f);
            
            if (_isForward)
                if (transform.position.z <= _distanceTarget)
                    transform.position += new Vector3(0, 0, _offset);
                else
                    _isForward = false;
            else
            if (transform.position.z >= _distanceTarget * -1)
                transform.position -= new Vector3(0, 0, _offset);
            else
                _isForward = true;
            
            yield return waitForSeconds;
        }
    }
    
    
}