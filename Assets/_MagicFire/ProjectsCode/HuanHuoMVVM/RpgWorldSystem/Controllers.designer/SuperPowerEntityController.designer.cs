// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MagicFire.HuanHuoMVVM {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SuperPowerEntityControllerBase : HealthEntityController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<SuperPowerEntityViewModel> _SuperPowerEntityViewModelManager;
        
        [uFrame.IOC.InjectAttribute("SuperPowerEntity")]
        public uFrame.MVVM.ViewModels.IViewModelManager<SuperPowerEntityViewModel> SuperPowerEntityViewModelManager {
            get {
                return _SuperPowerEntityViewModelManager;
            }
            set {
                _SuperPowerEntityViewModelManager = value;
            }
        }
        
        public IEnumerable<SuperPowerEntityViewModel> SuperPowerEntityViewModels {
            get {
                return SuperPowerEntityViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeSuperPowerEntity(((SuperPowerEntityViewModel)(viewModel)));
        }
        
        public virtual SuperPowerEntityViewModel CreateSuperPowerEntity() {
            return ((SuperPowerEntityViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new SuperPowerEntityViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeSuperPowerEntity(SuperPowerEntityViewModel viewModel) {
            // This is called when a SuperPowerEntityViewModel is created
            SuperPowerEntityViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            SuperPowerEntityViewModelManager.Remove(viewModel);
        }
    }
}
