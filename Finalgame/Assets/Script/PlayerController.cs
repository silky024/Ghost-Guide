using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 2.0f;
    public float JumpForce = 5.0f;
    private int score = 0;
    private Rigidbody2D _rigibody;

    void Start()
    {
        _rigibody = GetComponent<Rigidbody2D>();
    }

    public void AddScore()
    {
        score = score + 1;
    }

    public int GetScore()
    {
        return score;
    }
    // Update is called once per frame
    private void Update()
    {
        Debug.Log("play");
        var Movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, Movement))
            transform.rotation = Movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigibody.velocity.y) < 0.001f)
        {
            _rigibody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
