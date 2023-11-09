using System.Collections;
using UnityEngine;

public class MoverCube : MonoBehaviour
{
    private Coroutine _coroutineCube;
    
    private void Start() => _coroutineCube = StartCoroutine(MoveCube());

    private void OnDisable() => StopCoroutine(_coroutineCube);

    private IEnumerator MoveCube()
    {
        while (true)
        {
            transform.position += Vector3.forward * Time.deltaTime;
            
            yield return null;
        }
    }
}