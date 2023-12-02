using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _distance = 5f;
    [SerializeField] private float _moveSpeed = 10f;

    private Vector3 _startPosition;
    private Coroutine _coroutineMove;
    
    private void Start() => 
        _startPosition = transform.position;

    private void OnEnable() => 
        _coroutineMove = StartCoroutine(Move());

    private void OnDisable()
    {
        if (_coroutineMove is not null)
            StopCoroutine(_coroutineMove);
    }

    private IEnumerator Move()
    {
        float inaccuracy = 0.05f;
        
        while (true)
        {
            Vector3 targetPoint = new Vector3(transform.position.x, transform.position.y, _startPosition.z + _distance);
            
            while (Vector3.Distance(transform.position, targetPoint) > inaccuracy)
            {
                targetPoint = new Vector3(transform.position.x, transform.position.y, targetPoint.z);
                transform.position = Vector3.MoveTowards(transform.position, targetPoint, Time.deltaTime * _moveSpeed);
                
                yield return null;
            }

            _distance *= -1;
        }
    }
}