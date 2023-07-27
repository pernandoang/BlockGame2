using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector3 startPosition;

    private bool isDead = false;
    private bool isGameOver = false;
    public Text gameOverText;
    public Text levelText;
    void Start()
    {
        // Menyimpan posisi awal karakter
        startPosition = transform.position;
        gameOverText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Jika player mati, kembalikan dia ke posisi awal
        if (isDead)
        {
            transform.position = startPosition;
            isDead = false;
            return;
        }
        if (isGameOver)
        {
            // Tambahkan kode untuk menghentikan gerakan dan animasi player di sini
            gameOverText.enabled = true;
            return;
        }
    }

    // Fungsi yang dipanggil ketika player menyentuh collider lain
    void OnCollisionEnter2D(Collision2D other)
    {
        // Jika player menyentuh objek dengan tag "Obstacle", maka player mati
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isDead = true;
        }
        if (other.gameObject.CompareTag("GameOver"))
        {
            isGameOver = true;
        }
        if (other.gameObject.tag == "Level")
        {
            levelText.text = "Level 2";
        }
    }
}
