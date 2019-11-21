using Factorial.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Factorial.Core.ViewModels
{
    public class FactorialViewModel : MvxViewModel
    {
        private readonly IFactorialService _factorialService;
        private int _n;
        private double _result;
        private MvxCommand _calculateCommand;

        public FactorialViewModel(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            N = 0;
            Calculate();
        }

        private void Calculate()
        {
            Result = _factorialService.GetFactorial(N);
        }
    }
}
