namespace Livraria.Control
{
	public abstract class ControlBase
	{
		public ControlBase(View.IViewBase v)
		{
			v.setControl(this);
		}

		public abstract void iniciarView();
	}
}
