using UnityEngine;
using UnityEngine.UI;

public class GunShooting : MonoBehaviour
{
    public int score;
    public Text sc;
    public AudioClip NoHitSound = null;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D col = Physics2D.OverlapCircle(mousePos, 0.01f);

            if (col != null && col.CompareTag("circle"))
            {
                Target target = col.GetComponentInParent<Target>();
                target.Hit(mousePos);
                score += 9;
                sc.text = score.ToString("##");
                
            }


            if (col != null && col.CompareTag("firstduck"))
            {
                Target target = col.GetComponentInParent<Target>();
                target.Hit(mousePos);
                score += 3;
                sc.text = score.ToString("##");
                                             
            }

           else if (col != null && col.CompareTag("secondduck"))
            {
                Target target = col.GetComponentInParent<Target>();
                target.Hit(mousePos);
                score += 2;
                sc.text = score.ToString("##");
              
            }

            else
            {
                SoundPlayer.Play(NoHitSound);

            }

        }
    }

}
