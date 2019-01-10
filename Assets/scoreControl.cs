using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour {

    //スコアを表示するテキスト
    private GameObject scoreText;

    //スコアを保持
    private int totalScore;

    // Use this for initialization
    void Start () {
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        //スコアの初期値設定と得点表示
        totalScore = 0;
        SetScore();

    }

    void OnCollisionEnter(Collision collision)
    {
        string collisionGameObjectTag = collision.gameObject.tag;

        // スコアを加算
        if (collisionGameObjectTag == "SmallStarTag"){
            totalScore += 10;
        }else if (collisionGameObjectTag == "LargeStarTag"){
            totalScore += 20;
        }else if (collisionGameObjectTag == "SmallCloudTag"){
            totalScore += 30;
        }else if (collisionGameObjectTag == "LargeCloudTag"){
            totalScore += 40;
        }
        SetScore();
    }

    void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = string.Format("Score:{0}", totalScore);
    }
}
