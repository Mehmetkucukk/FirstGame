using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D myrb;
    public float jumpPower;
    public bool isDead;
    public Text SkorText;
    public int skor;
    public GameObject deadScreen;
    AudioSource sesler;
    public AudioSource seslertwo;
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
        sesler = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            Time.timeScale = 1;
            myrb.velocity = Vector2.up * jumpPower;
            sesler.Play();
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Borular"))
        {
            isDead = true;
            Time.timeScale = 0;
            deadScreen.SetActive(true);
            seslertwo.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("skorAraya"))
        {
            skor++;
            SkorText.text = skor.ToString();
        }
    }

}
