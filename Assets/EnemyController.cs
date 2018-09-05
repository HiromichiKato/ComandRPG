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

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
