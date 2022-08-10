using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject[] nochar;
    public float posisiMin, posisiMax;
    public int enemyCount;

    public float timeBetweenWaves = 3.0f;
    public Text waveText;
    private int waveCount;

    bool waveIsDone = true;

    // Start is called before the first frame update
    void Start()
    {
        waveCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave " + waveCount;

        if (waveIsDone == true)
        {
            StartCoroutine(Munculchar());
        }
    }

    IEnumerator Munculchar()
    {
        waveIsDone = false;

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject randomChar = nochar[Random.Range(0, nochar.Length)];
            Instantiate(randomChar, transform.position + Vector3.right * Random.Range(posisiMin, posisiMax), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
        waveCount += 1;
        yield return new WaitForSeconds(timeBetweenWaves);
        waveIsDone = true;
    }
}
