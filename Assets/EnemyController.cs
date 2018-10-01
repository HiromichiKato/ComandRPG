using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //hpを設定
    public float eneHP = 60;
    //攻撃力を設定
    public float enepower = 15;
    //防御力を設定
    public float enedefense = 5;
    //回復力を設定
    public float enerecovery = 10;
    //すばやさを設定
    public float enespeed = 15;
    //animationを入れる
    private Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }

    float TimeEDCount = 2;

    void Update() {
        if(enemyState == EnemyState.EIdel) {
            this.animator.SetBool("EAttack", false);
            this.animator.SetBool("EDefense", false);
            this.animator.SetBool("EMagic", false);
            this.animator.SetBool("ERecovery", false);
        }
        switch(enemyState) {
            case EnemyState.EAttack:
                this.animator.SetBool("EAttack", true);
                enemyState = EnemyState.EIdel;
                break;
            case EnemyState.EDefense:
                this.animator.SetBool("EDefense", true);
                enemyState = EnemyState.EIdel;
                break;
            case EnemyState.EMagic:
                this.animator.SetBool("EMagic", true);
                enemyState = EnemyState.EIdel;
                break;
            case EnemyState.ERecovery:
                this.animator.SetBool("ERecovery", true);
                enemyState = EnemyState.EIdel;
                break;
            case EnemyState.EDeath:
            TimeEDCount -= Time.deltaTime;
            if(TimeEDCount <= 0) {
                this.animator.SetBool("EDeath", true);
            }
                break;
        }

        if(eneHP <= 0) {
            enemyState = EnemyState.EDeath;
        }
    }

    EnemyState enemyState = EnemyState.EIdel;
    enum EnemyState {
        EIdel,
        EAttack,
        EDefense,
        EMagic,
        ERecovery,
        EDeath,
    }

    public void EnemyMovement() {
        if (eneHP > 25) {
            int num = Random.Range(1, 11);
            if (num <= 4) {
                Debug.Log("敵の攻撃。");
                enemyState = EnemyState.EAttack;
            }
            else if (num >= 5 && num <= 7) {
                Debug.Log("敵の必殺技。");
                enemyState = EnemyState.EMagic;
            }
            else {
                Debug.Log("敵は防御した。");
                enemyState = EnemyState.EDefense;
            }
        } else {
            int num = Random.Range(1, 11);
            if (num <= 3) {
                Debug.Log("敵は防御した。");
                enemyState = EnemyState.EDefense;
            }
            else {
                Debug.Log("敵は回復した。");
                enemyState = EnemyState.ERecovery;
            }
        }
    }
}

