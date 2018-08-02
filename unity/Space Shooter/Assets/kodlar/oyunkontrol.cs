using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour {

    public GameObject Asteroid;
    public Vector3 randomPos;
    public float baslangıcbekleme;
    public float olusturmabekleme;
    public float dongubekleme;
    int score;
    public Text text;
    bool oyunbittikontrol=false;
    bool yenidenbaslakontrol = false;
    public Text gameover;

    void Start () {
        StartCoroutine (olustur());
        score = 0;
        text.text = "score = " + score;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&& yenidenbaslakontrol)
        {
            SceneManager.LoadScene("main");
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds (baslangıcbekleme);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid,vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmabekleme);
                if (oyunbittikontrol)
                    break;

            }
            yield return new WaitForSeconds(dongubekleme);
            if (oyunbittikontrol)
                yenidenbaslakontrol = true;
                break;

        }
    }

    public void ScoreArttır(int gelenScore)
    {

        score += gelenScore;
        text.text = "score = " + score;
    }

    public void oyunbitti()
    {
        Debug.Log("oyun bitti");
        oyunbittikontrol = true;
        gameover.text = ("Game Over");
        text.text = "score = " + score + "   Press R to restart.";
    }
}
