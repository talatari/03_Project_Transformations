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

                Vector3 position = transform.position;
                
                position = new Vector3(position.x, transform.localScale.y * _offsetPosition, position.z);
                
                transform.position = position;

                yield return null;
            }
            
            while (transform.localScale.x >= _startScale.x)
            {
                transform.localScale -= _offsetScale * Time.deltaTime;

                Vector3 position = transform.position;
               
                position = new Vector3(position.x, transform.localScale.y * _offsetPosition, position.z);
                
                transform.position = position;

                yield return null;
            }
        }
    }
}
