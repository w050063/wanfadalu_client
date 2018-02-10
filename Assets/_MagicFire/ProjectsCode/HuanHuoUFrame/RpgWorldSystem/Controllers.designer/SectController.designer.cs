﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MagicFire.HuanHuoUFrame {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SectControllerBase : EntityCommonController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<SectViewModel> _SectViewModelManager;
        
        [uFrame.IOC.InjectAttribute("Sect")]
        public uFrame.MVVM.ViewModels.IViewModelManager<SectViewModel> SectViewModelManager {
            get {
                return _SectViewModelManager;
            }
            set {
                _SectViewModelManager = value;
            }
        }
        
        public IEnumerable<SectViewModel> SectViewModels {
            get {
                return SectViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeSect(((SectViewModel)(viewModel)));
        }
        
        public virtual SectViewModel CreateSect() {
            return ((SectViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new SectViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeSect(SectViewModel viewModel) {
            // This is called when a SectViewModel is created
            SectViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            SectViewModelManager.Remove(viewModel);
        }
    }
}
