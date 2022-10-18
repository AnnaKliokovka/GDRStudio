using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float step = 0.01f;

    private float MyEpsilon = 0.001f;
    private List<Vector2> Destinations;
    private Vector2 LastTouch;

    private void Start()
    {
        Destinations = new List<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            LastTouch = Camera.main.ScreenToWorldPoint(touch.position);
            Destinations.Add(LastTouch);
        }
        if (Destinations.Count>0)
        {
            StartCoroutine(Move(Destinations[0]));
            if (Vector3.Distance(transform.position, new Vector3(Destinations[0].x, Destinations[0].y, 0)) < MyEpsilon)
            {
                Destinations.RemoveAt(0);
            }
        }
    }
    private IEnumerator Move(Vector2 destination)
    {
        while (transform.position != new Vector3(destination.x, destination.y, 0))
        {
            transform.position = Vector2.MoveTowards(transform.position, destination, step);
            yield return null;
        }
    }
}
