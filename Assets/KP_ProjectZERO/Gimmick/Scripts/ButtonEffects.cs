using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonEffects : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void ClickToFade()
    {

        transform.DOScale(
    new Vector3(2, 2, 2), // スケール値
    1f                    // 演出時間
);
        image.DOFade(0, 1f).OnComplete(ClickToFade2);
    }

    void ClickToFade2()
    {
        GetComponent<ChangeScene>().PushStart();
    }
}
