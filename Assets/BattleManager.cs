using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    //それぞれの数値を入れるためにスクリプトを入れる
    public MonsterController monsterController;
    public EnemyController enemyController;
    //それぞれのButtonを入れる
    public GameObject Attack;
    public GameObject Defense;
    public GameObject Magic;
    public GameObject Recovery;

    // Use this for initialization
    void Start() {
        //それぞれの数値を代入
        float mHP = monsterController.monHP;
        float mPo = monsterController.power;
        float mDe = monsterController.defense;
        float mRe = monsterController.recover;
        float mMa = monsterController.magic;
        float mMP = monsterController.MP;
        float mNM = monsterController.needMP;
        float eHP = enemyController.eneHP;
        float ePo = enemyController.enepower;
        float eRe = enemyController.enerecovery;

    }

    enum BattlePhase {
        myCommandWait,
        myTurn,
        myTurnEnd,
        enemyCommandWait,
        enemyTurn,
        enemyTurnEnd,
    }


    BattlePhase phase = BattlePhase.myCommandWait;
    float TimeECWCount;
    float TimeETCount;

    void Update() {
        if(phase == BattlePhase.myCommandWait) {
            TimeETCount = 3;
            TimeECWCount = 4;
        }

        if(phase == BattlePhase.enemyCommandWait) {
            TimeECWCount -= Time.deltaTime;
            if (TimeECWCount <= 0) {
                phase = BattlePhase.enemyTurn;
            }
        }
        
        if(phase == BattlePhase.enemyTurnEnd) {
            TimeETCount -= Time.deltaTime;
            if(TimeETCount <= 0) {
                Attack.SetActive(true);
                Defense.SetActive(true);
                Magic.SetActive(true);
                Recovery.SetActive(true);
                phase = BattlePhase.myCommandWait;
            }
        }
        
        

        switch (phase) {
            case BattlePhase.myCommandWait:
                Debug.Log("コマンド待機中");
                break;

            case BattlePhase.myTurn:
                phase = BattlePhase.myTurnEnd;
                break;

            case BattlePhase.myTurnEnd:
                phase = BattlePhase.enemyCommandWait;
                break;

            case BattlePhase.enemyCommandWait:
                Debug.Log("敵行動待機中");
                break;

            case BattlePhase.enemyTurn:
                enemyController.EnemyMovement();
                phase = BattlePhase.enemyTurnEnd;
                break;

            case BattlePhase.enemyTurnEnd:
                break;
        }

    }

    public void OnClickAttack() {
        if (phase == BattlePhase.myCommandWait) {
            Attack.SetActive(false);
            Defense.SetActive(false);
            Magic.SetActive(false);
            Recovery.SetActive(false);
            phase = BattlePhase.myTurn;
        }
        enemyController.eneHP = enemyController.eneHP - monsterController.power;
        Debug.Log("" + monsterController.power + "のダメージを与えた。");
        Debug.Log("敵の残りHPは" + enemyController.eneHP);
    }

    public void OnClickDefense() {
        if (phase == BattlePhase.myCommandWait) {
            Attack.SetActive(false);
            Defense.SetActive(false);
            Magic.SetActive(false);
            Recovery.SetActive(false);
            phase = BattlePhase.myTurn;
        }
        Debug.Log("" + monsterController.defense + "のダメージを防いだ。");
    }

    public void OnClickMagic() {
        if (phase == BattlePhase.myCommandWait) {
            Attack.SetActive(false);
            Defense.SetActive(false);
            Magic.SetActive(false);
            Recovery.SetActive(false);
            phase = BattlePhase.myTurn;
        }
        monsterController.MP = monsterController.MP - monsterController.needMP;
        Debug.Log("MPを" + monsterController.needMP + "消費した。残りMPは" + monsterController.MP + "");
        Debug.Log("攻撃力が" + monsterController.magic + "上がった。");
    }

    public void OnClickRecovery() {
        if(phase == BattlePhase.myCommandWait) {
            Attack.SetActive(false);
            Defense.SetActive(false);
            Magic.SetActive(false);
            Recovery.SetActive(false);
            phase = BattlePhase.myTurn;
        }
        Debug.Log("HPを" + monsterController.recover + "回復した。");
    }

}



