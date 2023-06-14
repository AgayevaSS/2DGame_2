using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PoisonousPlant : MonoBehaviour
{
    [SerializeField] SpriteRenderer spiteRenderer;
    [SerializeField] Image image;
    [SerializeField] Color damageColor;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject health;
    [SerializeField] float _health = 100;

    Sequence sequence;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Obstactle"))
        {

            _health -= 10;
            image.fillAmount -= -0.1f;
            if (_health <= 0)
            {
                Destroy(gameObject);
                canvas.SetActive(true);
            }

            spiteRenderer.DOColor(damageColor, 0.2f).SetLoops(4, LoopType.Yoyo);
        }
    }


}
