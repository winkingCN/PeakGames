using System;
using Assets.Scripts.GamePlayScene;
using UnityEngine;

namespace GamePlayScene.Mechanics
{
	public class ItemResources : MonoBehaviour
	{
		[Serializable]
		public class AudioProps
		{
			public KOOGPFAPGGD AudioTag;

			public AudioClip AudioClip;
		}

		public GameObject Prefab;

		public ParticlePlayer[] Particles;

		public GameObject[] Animators;

		public AudioProps[] AudioClips;

		public Sprite[] Sprites;
	}
}
