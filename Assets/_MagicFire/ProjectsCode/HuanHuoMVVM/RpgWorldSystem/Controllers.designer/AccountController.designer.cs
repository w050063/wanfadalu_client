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
    
    
    public class AccountControllerBase : EntityCommonController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<AccountViewModel> _AccountViewModelManager;
        
        [uFrame.IOC.InjectAttribute("Account")]
        public uFrame.MVVM.ViewModels.IViewModelManager<AccountViewModel> AccountViewModelManager {
            get {
                return _AccountViewModelManager;
            }
            set {
                _AccountViewModelManager = value;
            }
        }
        
        public IEnumerable<AccountViewModel> AccountViewModels {
            get {
                return AccountViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeAccount(((AccountViewModel)(viewModel)));
        }
        
        public virtual AccountViewModel CreateAccount() {
            return ((AccountViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new AccountViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeAccount(AccountViewModel viewModel) {
            // This is called when a AccountViewModel is created
            AccountViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            AccountViewModelManager.Remove(viewModel);
        }
    }
}
