using System.Collections;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _maxScale = 3f;
    [SerializeField] private float _offsetPosition;

    private Vector3 _offsetScale;
    private Vector3 _startScale;
    
    private void Start()
    {
        _startScale = transform.localScale;
        _offsetScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        
        StartCoroutine(Scale());
    }

    private void OnDisable()
    {
        StopCoroutine(Scale());
    }
    
    private IEnumerator Scale()
    {
        while (true)
        {
            while (transform.localScale.x <= _maxScale)
            {
                transform.localScale += _offsetScale * Time.deltaTime;

                transform.position = new Vector3(transform.position.x, transform.localScale.y * _offsetPosition, transform.position.z);
                
                yield return null;
            }
            
            while (transform.localScale.x >= _startScale.x)
            {
                transform.localScale -= _offsetScale * Time.deltaTime;
                
                transform.position = new Vector3(transform.position.x, transform.localScale.y * _offsetPosition, transform.position.z);
                
                yield return null;
            }
        }
    }
}
