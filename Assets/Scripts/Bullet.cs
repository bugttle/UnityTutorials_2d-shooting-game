using UnityEngine;

public class Bullet : MonoBehaviour
{
		// 弾の移動スピード
		public int speed = 10;

		// 攻撃力
		public int power = 1;

		void OnEnable ()
		{
				// ローカル座標のY軸方向に移動する
				rigidbody2D.velocity = transform.up.normalized * speed;
		}
}
