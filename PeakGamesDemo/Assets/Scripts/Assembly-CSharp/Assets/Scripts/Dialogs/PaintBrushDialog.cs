namespace Assets.Scripts.Dialogs
{
	public class PaintBrushDialog : SimpleDialog
	{
		private bool CKHMCNBHPPD;

		private bool PPBAGGGJOKM;

		private LEDBLDKJBAI FDPKAAEPKDN = LEDBLDKJBAI.None;

		public bool IsCloseHappened()
		{
			return CKHMCNBHPPD;
		}

		internal bool NODFACBNKIF()
		{
			return PPBAGGGJOKM;
		}

		public override void OnDialogClosed()
		{
			CKHMCNBHPPD = true;
		}

		public void SelectColor(int LCMIJEGCDOE)
		{
			PPBAGGGJOKM = true;
			FDPKAAEPKDN = (LEDBLDKJBAI)LCMIJEGCDOE;
			Close();
		}

		internal LEDBLDKJBAI NEPCLOBAFEG()
		{
			return FDPKAAEPKDN;
		}
	}
}
