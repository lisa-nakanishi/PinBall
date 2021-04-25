using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //スコアを表示するテキスト
    public GameObject ScoreText;
    //スコアを初期化
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
        
        this.ScoreText = GameObject.Find("ScoreText");
       
    }
    void OnCollisionEnter(Collision collision)
    {
        string Tag = collision.gameObject.tag;
        //
        if(Tag== "SmallStarTag")
        {
            score += 10;
        }
        else if (Tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (Tag == "SmallCloudTag")
        {
            score += 15;
        }
        else if (Tag == "LargeCloudTag")
        {
            score += 30;
        }
        

    }


    // Update is called once per frame
    void Update()
    {
        //ScoreTextにスコアを表示
        this.ScoreText.GetComponent<Text>().text = "Score:" + score.ToString();
    }
}
