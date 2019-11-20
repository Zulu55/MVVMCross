namespace TipCalculator.Core.Services
{
	public interface ICalculationService
	{
		decimal TipAmount(decimal subTotal, double generosity);
	}
}
