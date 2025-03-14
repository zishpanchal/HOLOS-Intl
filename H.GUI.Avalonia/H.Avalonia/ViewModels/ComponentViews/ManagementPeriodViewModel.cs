﻿using System;

namespace H.Avalonia.ViewModels.ComponentViews
{
    public class ManagementPeriodViewModel : ViewModelBase
    {
        #region Fields

        private string _periodName;
        private DateTime _startDate;
        private DateTime _endDate;
        private int _numberOfDays;  

        #endregion

        #region Properties

        public string PeriodName 
        {
            get => _periodName;
            set
            {
                if(SetProperty(ref _periodName, value))
                {
                    ValidatePeriodName();
                }
            }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                if(SetProperty(ref _startDate, value))
                {
                    ValidateStartDate();
                }
            }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (SetProperty(ref _endDate, value))
                {
                    ValidateEndDate();
                }
            }
        }

        public int NumberOfDays
        {
            get => _numberOfDays;

            set
            {
                if (SetProperty(ref _numberOfDays, value))
                {
                    ValidateNumberOfDays();
                }
            }
        }

        #endregion

        #region Constructors

        public ManagementPeriodViewModel()
        {

        }

        #endregion

        #region Private Methods

        private void ValidatePeriodName()
        {
            RemoveError(nameof(PeriodName));

            if (string.IsNullOrEmpty(PeriodName))
            {
                AddError(nameof(PeriodName), H.Core.Properties.Resources.ErrorNameCannotBeEmpty);
                return;
            }
        }

        private void ValidateStartDate()
        {
            RemoveError(nameof(StartDate));

            if ((StartDate >= EndDate && EndDate != default) || StartDate == default)
            {
                AddError(nameof(StartDate), H.Core.Properties.Resources.ErrorStartDate);
                return;
            }
        }

        private void ValidateEndDate()
        {
            RemoveError(nameof(EndDate));

            if ((EndDate <= StartDate && StartDate != default) || EndDate == default)
            {
                AddError(nameof(EndDate), H.Core.Properties.Resources.ErrorEndDate);
                return;
            }
        }

        private void ValidateNumberOfDays()
        {
            RemoveError(nameof(NumberOfDays));

            if ( NumberOfDays <= 0)
            {
                AddError(nameof(NumberOfDays), H.Core.Properties.Resources.ErrorMustBeGreaterThan0);
                return;
            }
        }

        #endregion
    }
}
