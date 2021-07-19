using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public float fuel = 1;
    public float fuelConsumption = 0.1f;
    public Rigidbody2D FrontWheel;
    public Rigidbody2D BackWheel;
    public Rigidbody2D car;
    public float carSpeed = 50f;
    public float carTorque = -100f;
    float input;
    public Image fuelImage;
    public Score scoreText;
    public SavePlayerData savePlayerData;
    AudioSource playerAudio;
    public AudioClip CoinSound;

    

    private void Start()
    {
        Time.timeScale = 1;
        playerAudio = GetComponent<AudioSource>();
        
      
    }

    void Update()
    {
        input = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = fuel;
    }
    
    void FixedUpdate()
    {
        if (fuel > 0)
        {
            FrontWheel.AddTorque(input * carSpeed * Time.fixedDeltaTime);
            BackWheel.AddTorque(input * carSpeed * Time.fixedDeltaTime);
            car.AddTorque(input * carSpeed * Time.fixedDeltaTime);
        }
        if (fuel < 0)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
            savePlayerData.SetData();
            savePlayerData.GetData();

        }

            fuel -= fuelConsumption * Mathf.Abs(input) * Time.fixedDeltaTime;
        
    }
     private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.gameObject.CompareTag("Coin"))
        {
            playerAudio.clip = CoinSound;
            playerAudio.Play();
            other.gameObject.SetActive(false);
            Score.instance.ScoreUp();
        }
        if (gameObject.CompareTag("Trigger"))
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene());
            
        }
        
    }
    





}
