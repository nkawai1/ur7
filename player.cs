using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	//string型のmodeという変数を宣言しておきます
	private string mode;


	void Start () {
		

		//obj = GameObject.Find ("Explosion loop fallback");
		//ps = obj.GetComponent<ParticleSystem> ();
		//obj.SetActive (false);
	}

	void Update()
	{
		
			

		//modeの値がflyであった場合の処理

		//modeの値がlandであった場合の処理
		 if (mode == "land")
		{

			//UFOを下がりながら回転します。Vector3.upの前に-（マイナス）を付けて
			//下に降りるようにしています

			transform.Translate (0, 0, 0.01f);

		}
		else if (mode == "left")
		{



			transform.Translate (-0.01f, 0, 0);


		}
		else if (mode == "right")
		{


			transform.Translate (0.01f, 0, 0);


		}
		else if (mode == "stop")
		{


			transform.Translate (0, 0, 0);


		}

	}
	//Fly関数

	//Land関数
	public void Land()
	{
		//modeの値をlandで初期化します
		mode = "land";
	}



	public void Left()
	{
		//modeの値をleftで初期化します
		mode = "left";
	}

	public void Right()
	{
		//modeの値をrightで初期化します
		mode = "right";
	}
	public void stop()
	{
		//modeの値をrightで初期化します
		mode = "stop";
	}
	public void riset()
	{
		transform.localPosition = Vector3.zero;
	}
}

