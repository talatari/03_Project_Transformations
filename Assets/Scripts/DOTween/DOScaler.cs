using UnityEngine;
using DG.Tweening;

public class DOScaler : MonoBehaviour
{
    [SerializeField] private float _scaler = 3f;
    [SerializeField] private float _speedScale = 3f;
    
    private void Start() => 
        transform.DOScale(_scaler, _speedScale).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
}