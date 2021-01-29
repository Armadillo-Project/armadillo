using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRotation : MonoBehaviour
{

    float angle;
    float stopAngle;
    Vector2 target, mouse;
    public bool check = true;
    float timer=0;
    Color color;


    private void Start()
    {
        target = transform.position;
    }
    private void Update()
    {
        disappear();

        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        //this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        if (Input.GetMouseButtonDown(0)&&check)
        {
            stopAngle = angle;
            this.transform.rotation = Quaternion.AngleAxis(stopAngle - 90, Vector3.forward);
            check = false;
            timer = 5.0f;
            StartCoroutine(WaitForIt());
            timer = 0;
        }


    }
    IEnumerator WaitForIt()
    {
        while(timer > 1.0f)
        {
            timer -= Time.deltaTime;
            appear();
            yield return new WaitForSeconds(0.02f);
        }

        check = true;
    }

    public void appear()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        Color color = spr.color;
        color.a = 1f;
        spr.color = color;

    }

    public void disappear()
    {
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        Color color = spr.color;
        color.a = 0f;
        spr.color = color;

    }
}
