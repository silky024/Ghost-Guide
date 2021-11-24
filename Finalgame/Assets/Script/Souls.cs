using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souls : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(Collected(collision.gameObject));
        }
    }

    IEnumerator Collected(GameObject gameObj)
    {
        gameObject.GetComponent<AudioSource>().Play();

        print("collected");
        PlayerController player = gameObj.GetComponent<PlayerController>();

        gameObject.GetComponent<CircleCollider2D>().enabled = false;

        print(player);
        player.AddScore();
        while (gameObject.GetComponent<AudioSource>().isPlaying)
        {
            yield return new WaitForSeconds(0.1f);
        }


        gameObject.SetActive(false);

        yield return null;
    }

}
