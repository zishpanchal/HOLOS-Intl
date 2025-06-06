﻿using Prism.Regions;
using Prism.Commands;

namespace H.Avalonia.ViewModels.Results
{
    public class ResultsViewModelBase : ViewModelBase
    {
        private bool _processing;
        
        protected ResultsViewModelBase() { }

        protected ResultsViewModelBase(IRegionManager regionManager) : base(regionManager)
        {
        }

        /// <summary>
        /// A command that triggers when a user clicks the back button on the page.
        /// </summary>
        public DelegateCommand GoBackCommand { get; set; }

        /// <summary>
        /// A command that triggers when a user clicks the export to csv button on the page.
        /// </summary>
        public DelegateCommand<object> ExportToCsvCommand { get; set; }
        
        /// <summary>
        /// A bool that checks if data extraction is currently processing or not. Returns true if data is still processing, return false otherwise.
        /// </summary>
        public bool IsProcessingData
        {
            get => _processing;
            set => SetProperty(ref _processing, value);
        }
    }
}
