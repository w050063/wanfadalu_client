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
    
    
    public class RpgMainScreenControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<RpgMainScreenViewModel> _RpgMainScreenViewModelManager;
        
        private MessageBoxViewModel _MessageBox;
        
        private UserLoginScreenViewModel _UserLoginScreen;
        
        private RpgMainScreenViewModel _RpgMainScreen;
        
        [uFrame.IOC.InjectAttribute("RpgMainScreen")]
        public uFrame.MVVM.ViewModels.IViewModelManager<RpgMainScreenViewModel> RpgMainScreenViewModelManager {
            get {
                return _RpgMainScreenViewModelManager;
            }
            set {
                _RpgMainScreenViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("MessageBox")]
        public MessageBoxViewModel MessageBox {
            get {
                return _MessageBox;
            }
            set {
                _MessageBox = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("UserLoginScreen")]
        public UserLoginScreenViewModel UserLoginScreen {
            get {
                return _UserLoginScreen;
            }
            set {
                _UserLoginScreen = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("RpgMainScreen")]
        public RpgMainScreenViewModel RpgMainScreen {
            get {
                return _RpgMainScreen;
            }
            set {
                _RpgMainScreen = value;
            }
        }
        
        public IEnumerable<RpgMainScreenViewModel> RpgMainScreenViewModels {
            get {
                return RpgMainScreenViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeRpgMainScreen(((RpgMainScreenViewModel)(viewModel)));
        }
        
        public virtual RpgMainScreenViewModel CreateRpgMainScreen() {
            return ((RpgMainScreenViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new RpgMainScreenViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeRpgMainScreen(RpgMainScreenViewModel viewModel) {
            // This is called when a RpgMainScreenViewModel is created
            viewModel.ShowCharacterInfoPanel.Action = this.ShowCharacterInfoPanelHandler;
            viewModel.ExitGame.Action = this.ExitGameHandler;
            RpgMainScreenViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            RpgMainScreenViewModelManager.Remove(viewModel);
        }
        
        public virtual void ShowCharacterInfoPanelHandler(ShowCharacterInfoPanelCommand command) {
            this.ShowCharacterInfoPanel(command.Sender as RpgMainScreenViewModel, command);
        }
        
        public virtual void ExitGameHandler(ExitGameCommand command) {
            this.ExitGame(command.Sender as RpgMainScreenViewModel, command);
        }
        
        public virtual void ShowCharacterInfoPanel(RpgMainScreenViewModel viewModel, ShowCharacterInfoPanelCommand arg) {
        }
        
        public virtual void ExitGame(RpgMainScreenViewModel viewModel, ExitGameCommand arg) {
        }
    }
}
