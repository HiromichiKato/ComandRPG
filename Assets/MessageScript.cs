using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageScript : MonoBehaviour {

　  //BattleManagerを入れる
    public BattleManager battleManager;
	//メッセージUI
    private Text messageText;
	//表示するメッセージ
	private string message;
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
	//テキストスピード
	[SerializeField]
	private float textSpeed = 0.05f;
	//経過時間
	private float elapsedTime = 0f;
	//今見ている文字数
	private int nowTextNum = 0;
	//マウスのクリックを促すアイコン
	private Image clickIcon;
	//クリックアイコンの点滅秒数
	[SerializeField]
	private float clickFlashTime = 0.2f;
	//1回分メッセージを表示したかどうか
	private bool isOneMessage = false;
	//メッセージをすべて表示したかどうか
	private bool isEndMessage = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
