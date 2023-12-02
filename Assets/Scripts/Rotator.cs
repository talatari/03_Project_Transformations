using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _moveRotate = 200f;
    
    private Coroutine _coroutineRotate;

    private void OnEnable()
    {
        _coroutineRotate = StartCoroutine(Rotate());
    }

    private void OnDisable()
    {
        if (_coroutineRotate is not null)
            StopCoroutine(_coroutineRotate);
    }

    private IEnumerator Rotate()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * _moveRotate);
            
            yield return null;
        }
    }
}
