using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageScript : MonoBehaviour {

	//メッセージUI
    public Text messageText;
	//表示するメッセージ
	public string message;
	//1回のメッセージの最大文字数
	[SerializeField]
	private int maxTextLength = 90;
	//1回のメッセージの現在の文字数
	private int textLength = 0;
	//メッセージの最大行数
	[SerializeField]
	private int maxLine = 3;
	//現在の行
	private int nowLine = 0;
	

	


	// Use this for initialization
	void Start () {
		messageText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	public void SetStartMessage() {
		messageText.text = "OOOはどうする？";
	}
	public void SetAttackMessage() {
		messageText.text = "OOOの攻撃。";
	}
	public void SetdefenseMessage() {
		messageText.text = "OOOは身を固めた。";
	}
	public void SetMagicMessage() {
		messageText.text = "OOOは魔法を使った。";
	}
	public void SetRecoveryMessage() {
		messageText.text = "OOOはHPを回復した。";
	}

	public void SetEAttackMessage() {
		messageText.text = "敵は攻撃した。";
	}
	public void SetEDAefenseMessage() {
		messageText.text = "敵は防御した。";
	}
	public void SetEMagicMessage() {
		messageText.text = "敵の魔法を使った。";
	}
	public void SetERecoveryMessage() {
		messageText.text = "敵は回復した。";
	}
	public void SetEDeathMessage() {
		messageText.text = "敵を倒した。";
	}
}
