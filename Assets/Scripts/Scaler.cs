using System.Collections;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _maxScale = 3f;
    [SerializeField] private float _offsetPosition;

    private Vector3 _offsetScale;
    private Vector3 _startScale;
    private Coroutine _coroutineScale;
    
    private void Start()
    {
        _startScale = transform.localScale;
        _offsetScale = new Vector3(_startScale.x, _startScale.y, _startScale.z);
    }

    private void OnEnable() => 
        _coroutineScale = StartCoroutine(Scale());

    private void OnDisable()
    {
        if (_coroutineScale != null)
            StopCoroutine(_coroutineScale);
    }

    private IEnumerator Scale()
    {
        while (true)
        {
            while (transform.localScale.x <= _maxScale)
            {
                ModifyPositionScale(_offsetScale);
                yield return null;
            }
            
            while (transform.localScale.x >= _startScale.x)
            {
                ModifyPositionScale(_offsetScale * -1);
                yield return null;
            }
        }
    }

    private void ModifyPositionScale(Vector3 offsetScale)
    {
        transform.localScale += offsetScale * Time.deltaTime;

        Vector3 position = transform.position;
        position = new Vector3(position.x, _startScale.y * _offsetPosition, position.z);

        transform.position = position;
    }
}
