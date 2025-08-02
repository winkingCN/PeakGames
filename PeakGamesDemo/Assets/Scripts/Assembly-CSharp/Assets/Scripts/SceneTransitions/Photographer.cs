using System;
using Assets.Scripts.GamePlayScene.Mechanics;
using UnityEngine;

namespace Assets.Scripts.SceneTransitions
{
	public class Photographer : MonoBehaviour
	{
		public Camera MasterCamera;

		public Camera SelfCamera;

		public SpriteRenderer BackgroundDisplayer;

		public LevelBuilder CurrentLevelBuilder;

		public LayerMask Layer1;

		public void TakeShot()
		{
			SelfCamera.transform.position = MasterCamera.transform.position;
			SelfCamera.orthographicSize = MasterCamera.orthographicSize;
			int pixelWidth = SelfCamera.pixelWidth;
			int pixelHeight = SelfCamera.pixelHeight;
			SelfCamera.cullingMask = Layer1;
			RenderTexture renderTexture = new RenderTexture(pixelWidth, pixelHeight, 0, RenderTextureFormat.ARGB32);
			SelfCamera.targetTexture = renderTexture;
			SelfCamera.Render();
			RenderTexture.active = renderTexture;
			TextureFormat format = TextureFormat.RGB24;
			Texture2D texture2D = new Texture2D(pixelWidth, pixelHeight, format, false);
			texture2D.name = "PhotoBackgroundTexture";
			Rect rect = new Rect(0f, 0f, pixelWidth, pixelHeight);
			texture2D.ReadPixels(rect, 0, 0);
			texture2D.Apply();
			Sprite sprite = Sprite.Create(texture2D, rect, new Vector2(0.5f, 0.5f), 100f);
			sprite.name = "PhotoBackgroundSprite";
			RenderTexture.active = null;
			BackgroundDisplayer.sprite = sprite;
			SelfCamera.targetTexture = null;
			UnityEngine.Object.Destroy(renderTexture);
			float num = 100f * (MasterCamera.orthographicSize * 2f) / (float)pixelHeight;
			BackgroundDisplayer.transform.localScale = new Vector3(num, num, num);
			SelfCamera.enabled = false;
			BackgroundDisplayer.enabled = true;
			MasterCamera.clearFlags = CameraClearFlags.Color;
			GameObject[] array = GameObject.FindGameObjectsWithTag("ToBePhotographed");
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.Destroy(array[i]);
			}
			UnityEngine.Object.Destroy(base.gameObject);
			GC.Collect();
		}
	}
}
