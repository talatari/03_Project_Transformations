using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]
public class DOColorer : MonoBehaviour
{
    [SerializeField] private float _speedColorChange = 3f;
    
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material.DOColor(Color.red, _speedColorChange).SetLoops(-1, LoopType.Yoyo);
    }
}