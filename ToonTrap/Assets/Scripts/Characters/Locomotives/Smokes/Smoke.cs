using DG.Tweening;
using FTRuntime;
using UnityEngine;

namespace Ryocatusn.Characters
{
    [RequireComponent(typeof(SwfClip))]
    public class Smoke : MonoBehaviour
    {
        private void Start()
        {
            SwfClip swfClip = GetComponent<SwfClip>();

            Sequence sequence = DOTween.Sequence();

            sequence
                .SetLink(gameObject)
                .Append(transform.DOScale(0.7f, 2))
                .Join(DoFade(0, 2))
                .OnComplete(() => Destroy(gameObject.transform.parent.gameObject));

            Tween DoFade(float endValue, float duration)
            {
                return DOTween.To
                    (
                    () => swfClip.tint,
                    x => swfClip.tint = x,
                    new Color(swfClip.tint.r, swfClip.tint.g, swfClip.tint.b, endValue),
                    duration
                    );
            }
        }
    }
}
