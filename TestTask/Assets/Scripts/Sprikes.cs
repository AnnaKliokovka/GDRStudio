using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprikes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(plz(collision));
        }
    }
    IEnumerator plz(Collider2D collision)
    {
        collision.GetComponent<PlayerManager>().PopedBall();
        yield return new WaitForSeconds(2);
        Camera.main.GetComponent<MyMenu>().ShowRestart();
    }
}
