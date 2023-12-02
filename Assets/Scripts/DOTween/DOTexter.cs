using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DOTexter : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _speedChanges = 4f;
    [SerializeField] private int _delay = 4;
    
    private void Start()
    {
        int incrementDelay = 4;
        
        _text.DOText("Замена на этот текст", _speedChanges)
            .SetDelay(_delay);

        _text.DOText("\n A этим текстом текст был обогащён", _speedChanges)
            .SetRelative().SetDelay(_delay += incrementDelay);

        _text.DOText("Замена текста совсем другим текстом с эффектом перебора", _speedChanges, true, ScrambleMode.All)
            .SetDelay(_delay += incrementDelay);

        _text.DOColor(Color.red, _speedChanges)
            .SetDelay(_delay += incrementDelay);
    }
}