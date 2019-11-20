﻿using System.Windows.Input;
using Factorial.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

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

        private void Calculate()
        {
            Result = _factorialService.CalculateFactorial(N);
        }
    }
}
