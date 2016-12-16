using UnityEngine;
using System.Collections;

/// <summary>
/// プレイヤー生成を管理.
/// </summary>
public class PlayerGenerator : MonoBehaviour {

	private const float		PLAYER_RADIUS = 6f;
	private const int 		PLAYER_MAX = 15;

	[SerializeField]
	private GameObject		m_PlayerPrefab;

	[SerializeField]
	private Transform		m_PlayerRoot;

	void Awake()
	{
		for (int i = 0; i < PLAYER_MAX; i++) {
			GameObject _obj = Instantiate (m_PlayerPrefab) as GameObject;
			Transform _trans = _obj.transform;

			float _deg = (i * (360f / PLAYER_MAX));
			float _rad = Mathf.Deg2Rad * _deg;

			float _posX = Mathf.Sin (_rad) * PLAYER_RADIUS;
			float _posZ = Mathf.Cos (_rad) * PLAYER_RADIUS;

			_trans.position = new Vector3 (_posX, 0f, _posZ);
			_trans.parent = m_PlayerRoot;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
