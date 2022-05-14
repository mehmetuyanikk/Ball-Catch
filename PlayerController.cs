using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    [SerializeField] int _score;
    [SerializeField] Text _sonuc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Top")
        {
            _score += 1;
            _sonuc.text = "Sonuç: " + _score.ToString();
            Debug.Log("Score: " + _score);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Çarpmaya devam ediyor");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Çarpma bitti");
    }

}
