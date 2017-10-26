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
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public partial class RpgMainScreenViewModelBase : uFrame.MVVM.ViewModels.ViewModel {
        
        private Signal<ShowCharacterInfoPanelCommand> _ShowCharacterInfoPanel;
        
        private Signal<ExitGameCommand> _ExitGame;
        
        public RpgMainScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual Signal<ShowCharacterInfoPanelCommand> ShowCharacterInfoPanel {
            get {
                return _ShowCharacterInfoPanel;
            }
            set {
                _ShowCharacterInfoPanel = value;
            }
        }
        
        public virtual Signal<ExitGameCommand> ExitGame {
            get {
                return _ExitGame;
            }
            set {
                _ExitGame = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.ShowCharacterInfoPanel = new Signal<ShowCharacterInfoPanelCommand>(this);
            this.ExitGame = new Signal<ExitGameCommand>(this);
        }
        
        public virtual void Execute(ShowCharacterInfoPanelCommand argument) {
            this.ShowCharacterInfoPanel.OnNext(argument);
        }
        
        public virtual void Execute(ExitGameCommand argument) {
            this.ExitGame.OnNext(argument);
        }
        
        public virtual void ShowCharacterInfoPanel_() {
            var cmd = new ShowCharacterInfoPanelCommand();
            this.ShowCharacterInfoPanel.OnNext(cmd);
        }
        
        public virtual void ExitGame_() {
            var cmd = new ExitGameCommand();
            this.ExitGame.OnNext(cmd);
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("ShowCharacterInfoPanel", ShowCharacterInfoPanel) { ParameterType = typeof(ShowCharacterInfoPanelCommand) });
            list.Add(new ViewModelCommandInfo("ExitGame", ExitGame) { ParameterType = typeof(ExitGameCommand) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
        }
    }
    
    public partial class RpgMainScreenViewModel {
        
        public RpgMainScreenViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
