public static class OONBCFPMHNH
{
	public static IEKBFJBLGFM JNGHEHKEBMN(this IEKBFJBLGFM IAPHFDOKNAN)
	{
		switch (IAPHFDOKNAN)
		{
		case IEKBFJBLGFM.Up:
			return IEKBFJBLGFM.Down;
		case IEKBFJBLGFM.Down:
			return IEKBFJBLGFM.Up;
		case IEKBFJBLGFM.LeftUp:
			return IEKBFJBLGFM.RightDown;
		case IEKBFJBLGFM.Left:
			return IEKBFJBLGFM.Right;
		case IEKBFJBLGFM.LeftDown:
			return IEKBFJBLGFM.RightUp;
		case IEKBFJBLGFM.RightUp:
			return IEKBFJBLGFM.LeftDown;
		case IEKBFJBLGFM.Right:
			return IEKBFJBLGFM.Left;
		case IEKBFJBLGFM.RightDown:
			return IEKBFJBLGFM.LeftUp;
		default:
			return IEKBFJBLGFM.None;
		}
	}
}
