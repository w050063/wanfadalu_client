// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MagicFire.HuanHuoUFrame {
    using MagicFire.HuanHuoUFrame;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class HealthEntityControllerBase : EntityCommonController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<HealthEntityViewModel> _HealthEntityViewModelManager;
        
        [uFrame.IOC.InjectAttribute("HealthEntity")]
        public uFrame.MVVM.ViewModels.IViewModelManager<HealthEntityViewModel> HealthEntityViewModelManager {
            get {
                return _HealthEntityViewModelManager;
            }
            set {
                _HealthEntityViewModelManager = value;
            }
        }
        
        public IEnumerable<HealthEntityViewModel> HealthEntityViewModels {
            get {
                return HealthEntityViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeHealthEntity(((HealthEntityViewModel)(viewModel)));
        }
        
        public virtual HealthEntityViewModel CreateHealthEntity() {
            return ((HealthEntityViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new HealthEntityViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeHealthEntity(HealthEntityViewModel viewModel) {
            // This is called when a HealthEntityViewModel is created
            viewModel.OnRespawn.Action = this.OnRespawnHandler;
            viewModel.OnDead.Action = this.OnDeadHandler;
            HealthEntityViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            HealthEntityViewModelManager.Remove(viewModel);
        }
        
        public virtual void OnRespawnHandler(OnRespawnCommand command) {
            this.OnRespawn(command.Sender as HealthEntityViewModel, command);
        }
        
        public virtual void OnDeadHandler(OnDeadCommand command) {
            this.OnDead(command.Sender as HealthEntityViewModel, command);
        }
        
        public virtual void OnRespawn(HealthEntityViewModel viewModel, OnRespawnCommand arg) {
        }
        
        public virtual void OnDead(HealthEntityViewModel viewModel, OnDeadCommand arg) {
        }
    }
}
