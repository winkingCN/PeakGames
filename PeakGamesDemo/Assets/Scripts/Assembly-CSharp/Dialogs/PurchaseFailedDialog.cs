using TMPro;

namespace Dialogs
{
	public class PurchaseFailedDialog : DefaultDialog
	{
		public TextMeshPro ErrorText;

		public TextMeshPro ErrorTitleText;

		public void SetErrorText(int DIDHNNMKJFE)
		{
			string text = NKILHODNBDE.GHBGCADFLFB("PurchaseFailedMessage");
			string text2 = NKILHODNBDE.GHBGCADFLFB("Failed");
			switch (DIDHNNMKJFE)
			{
			case 2:
				text = NKILHODNBDE.GHBGCADFLFB("PurchaseCanceledMessage");
				text2 = NKILHODNBDE.GHBGCADFLFB("Canceled");
				break;
			case 3:
				text = NKILHODNBDE.GHBGCADFLFB("PurchaseTechnicalProblemMessage");
				break;
			case 4:
				text = NKILHODNBDE.GHBGCADFLFB("PurchaseInProgressMessage");
				break;
			}
			ErrorText.FCJBBPHFNPJ = text;
			ErrorTitleText.FCJBBPHFNPJ = text2;
		}
	}
}
