using System.Collections.Generic;
using UnityEngine;

namespace ToonSocial
{
	public class Badges : MonoBehaviour
	{
		public Sprite[] BadgeSprites;

		public Sprite[] RandomBadges;

		public Sprite DefaultSprite;

		public Sprite BlankSprite;

		private readonly Dictionary<string, Sprite> MLPOPKFKIKI = new Dictionary<string, Sprite>();

		public void Awake()
		{
			if (BadgeSprites != null)
			{
				Sprite[] badgeSprites = BadgeSprites;
				foreach (Sprite sprite in badgeSprites)
				{
					MLPOPKFKIKI[sprite.name] = sprite;
				}
			}
		}

		public Sprite GetRandomBadge()
		{
			return RandomBadges[Random.Range(0, RandomBadges.Length)];
		}

		public Sprite GetBadge(string IDHLPOFDLKJ)
		{
			if (IDHLPOFDLKJ == null)
			{
				return DefaultSprite;
			}
			Sprite value;
			return MLPOPKFKIKI.TryGetValue(IDHLPOFDLKJ, out value) ? value : DefaultSprite;
		}
	}
}
