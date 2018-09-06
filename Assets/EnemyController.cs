using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //hpを設定
    public float eneHP = 50;
    //攻撃力を設定
    public float enepower = 15;
    //防御力を設定
    public float enedefense = 5;
    //すばやさを設定
    public float enespeed = 15;
    //animationを入れる
    private Animator animator;

    bool isAttack;
    bool isDefense;
    bool isMagic;
    bool isRecovery;


    public void EAPush() {
        isAttack = true;
    }
    public void noEAPush() {
        isAttack = false;
    }
    public void EDPush() {
        isDefense = true;
    }
    public void noEDPush() {
        isDefense = false;
    }
    public void EMPush() {
        isMagic = true;
    }
    public void noEMPush() {
        isMagic = false;
    }
    public void ERPush() {
        isRecovery = true;
    }
    public void noERPush() {
        isRecovery = false;
    }

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isAttack == true) {
            this.animator.SetBool("Attack", true);
        }
        else {
            this.animator.SetBool("Attack", false);
        }

        if (isDefense == true) {
            this.animator.SetBool("Defense", true);
        }
        else {
            this.animator.SetBool("Defense", false);
        }

        if (isMagic == true) {
            this.animator.SetBool("Magic", true);
        }
        else {
            this.animator.SetBool("Magic", false);
        }

        if (isRecovery == true) {
            this.animator.SetBool("Recovery", true);
        }
        else {
            this.animator.SetBool("Recovery", false);
        }
	}
}
