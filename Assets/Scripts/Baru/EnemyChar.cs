using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChar : BaseCharacter, IRaycastable
{
    private Scoring skor;

    void Start()
    {
        skor = FindObjectOfType<Scoring>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Move();

        if (transform.position.y <= -5)
        {
            GameControl.health -= 1;
            Destroy(gameObject);
        }
    }

    public void OnClick()
    {
        skor.addScore();
        Destroy(gameObject);
        Debug.Log("klik");
    }
}