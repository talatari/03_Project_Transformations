using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _moveRotate = 200f;
    
    private Coroutine _coroutineRotate;
    
    private void Start() => _coroutineRotate = StartCoroutine(Rotate());

    private void OnDisable() => StopCoroutine(_coroutineRotate);

    private IEnumerator Rotate()
    {
        while (true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * _moveRotate);
            
            yield return null;
        }
    }
}
