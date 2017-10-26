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
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class RpgMainPanelBase : uFrame.MVVM.Views.ViewBase {
        
        [uFrame.MVVM.Attributes.UFToggleGroup("ExitGame")]
        [UnityEngine.HideInInspector()]
        public bool _BindExitGame = true;
        
        [uFrame.MVVM.Attributes.UFGroup("ExitGame")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_ExitGamebutton")]
        protected UnityEngine.UI.Button _ExitGameButton;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("ShowCharacterInfoPanel")]
        [UnityEngine.HideInInspector()]
        public bool _BindShowCharacterInfoPanel = true;
        
        [uFrame.MVVM.Attributes.UFGroup("ShowCharacterInfoPanel")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_ShowCharacterInfoPanelbutton")]
        protected UnityEngine.UI.Button _ShowCharacterInfoPanelButton;
        
        public override string DefaultIdentifier {
            get {
                return "RpgMainScreen";
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(RpgMainScreenViewModel);
            }
        }
        
        public RpgMainScreenViewModel RpgMainScreen {
            get {
                return (RpgMainScreenViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as RpgMainScreenViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.RpgMainScreen to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindExitGame) {
                this.BindButtonToCommand(_ExitGameButton, this.RpgMainScreen.ExitGame);
            }
            if (_BindShowCharacterInfoPanel) {
                this.BindButtonToCommand(_ShowCharacterInfoPanelButton, this.RpgMainScreen.ShowCharacterInfoPanel);
            }
        }
        
        public virtual void ExecuteShowCharacterInfoPanel(ShowCharacterInfoPanelCommand command) {
            command.Sender = RpgMainScreen;
            RpgMainScreen.ShowCharacterInfoPanel.OnNext(command);
        }
        
        public virtual void ExecuteExitGame(ExitGameCommand command) {
            command.Sender = RpgMainScreen;
            RpgMainScreen.ExitGame.OnNext(command);
        }
    }
}
