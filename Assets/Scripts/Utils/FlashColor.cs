using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlashColor : MonoBehaviour
{
    public List<SpriteRenderer> spriteRenderers;
    public Color color = Color.red;
    public float duration = .3f;

    private List<Tween> _currentTweens = new List<Tween>();

    private void OnValidate()
    {
        spriteRenderers = new List<SpriteRenderer>();
        foreach (var child in transform.GetComponentsInChildren<SpriteRenderer>())
        {
            spriteRenderers.Add(child);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Flash();
        }
    }

    public void StopFlashColor()
    {
        if (_currentTweens != null && _currentTweens.Count > 0)
        {
            for (int i = _currentTweens.Count - 1; i >= 0; --i)
            {
                _currentTweens[i].Kill();
                _currentTweens.RemoveAt(i);
            }
            spriteRenderers.ForEach( i=> i.color = Color.white);
        }
    }

    public void Flash()
    {
        StopFlashColor();
        foreach(var x in spriteRenderers)
        {
            _currentTweens.Add(x.DOColor(color, duration).SetLoops(2, LoopType.Yoyo));
        }
    }
}
