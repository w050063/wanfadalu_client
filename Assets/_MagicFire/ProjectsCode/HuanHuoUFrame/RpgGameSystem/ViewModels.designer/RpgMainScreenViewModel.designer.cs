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
        
        private Signal<ShowSectPanelCommand> _ShowSectPanel;
        
        private Signal<ShowAvatarBagPanelCommand> _ShowAvatarBagPanel;
        
        private Signal<ExitArenaCommand> _ExitArena;
        
        private Signal<ShowRankingListPanelCommand> _ShowRankingListPanel;
        
        private Signal<ShowCharacterInfoPanelCommand> _ShowCharacterInfoPanel;
        
        private Signal<ShowGongFaPanelCommand> _ShowGongFaPanel;
        
        private Signal<ExitGameCommand> _ExitGame;
        
        public RpgMainScreenViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual Signal<ShowSectPanelCommand> ShowSectPanel {
            get {
                return _ShowSectPanel;
            }
            set {
                _ShowSectPanel = value;
            }
        }
        
        public virtual Signal<ShowAvatarBagPanelCommand> ShowAvatarBagPanel {
            get {
                return _ShowAvatarBagPanel;
            }
            set {
                _ShowAvatarBagPanel = value;
            }
        }
        
        public virtual Signal<ExitArenaCommand> ExitArena {
            get {
                return _ExitArena;
            }
            set {
                _ExitArena = value;
            }
        }
        
        public virtual Signal<ShowRankingListPanelCommand> ShowRankingListPanel {
            get {
                return _ShowRankingListPanel;
            }
            set {
                _ShowRankingListPanel = value;
            }
        }
        
        public virtual Signal<ShowCharacterInfoPanelCommand> ShowCharacterInfoPanel {
            get {
                return _ShowCharacterInfoPanel;
            }
            set {
                _ShowCharacterInfoPanel = value;
            }
        }
        
        public virtual Signal<ShowGongFaPanelCommand> ShowGongFaPanel {
            get {
                return _ShowGongFaPanel;
            }
            set {
                _ShowGongFaPanel = value;
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
            this.ShowSectPanel = new Signal<ShowSectPanelCommand>(this);
            this.ShowAvatarBagPanel = new Signal<ShowAvatarBagPanelCommand>(this);
            this.ExitArena = new Signal<ExitArenaCommand>(this);
            this.ShowRankingListPanel = new Signal<ShowRankingListPanelCommand>(this);
            this.ShowCharacterInfoPanel = new Signal<ShowCharacterInfoPanelCommand>(this);
            this.ShowGongFaPanel = new Signal<ShowGongFaPanelCommand>(this);
            this.ExitGame = new Signal<ExitGameCommand>(this);
        }
        
        public virtual void Execute(ShowSectPanelCommand argument) {
            this.ShowSectPanel.OnNext(argument);
        }
        
        public virtual void Execute(ShowAvatarBagPanelCommand argument) {
            this.ShowAvatarBagPanel.OnNext(argument);
        }
        
        public virtual void Execute(ExitArenaCommand argument) {
            this.ExitArena.OnNext(argument);
        }
        
        public virtual void Execute(ShowRankingListPanelCommand argument) {
            this.ShowRankingListPanel.OnNext(argument);
        }
        
        public virtual void Execute(ShowCharacterInfoPanelCommand argument) {
            this.ShowCharacterInfoPanel.OnNext(argument);
        }
        
        public virtual void Execute(ShowGongFaPanelCommand argument) {
            this.ShowGongFaPanel.OnNext(argument);
        }
        
        public virtual void Execute(ExitGameCommand argument) {
            this.ExitGame.OnNext(argument);
        }
        
        public virtual void ShowSectPanel_() {
            var cmd = new ShowSectPanelCommand();
            this.ShowSectPanel.OnNext(cmd);
        }
        
        public virtual void ShowAvatarBagPanel_() {
            var cmd = new ShowAvatarBagPanelCommand();
            this.ShowAvatarBagPanel.OnNext(cmd);
        }
        
        public virtual void ExitArena_() {
            var cmd = new ExitArenaCommand();
            this.ExitArena.OnNext(cmd);
        }
        
        public virtual void ShowRankingListPanel_() {
            var cmd = new ShowRankingListPanelCommand();
            this.ShowRankingListPanel.OnNext(cmd);
        }
        
        public virtual void ShowCharacterInfoPanel_() {
            var cmd = new ShowCharacterInfoPanelCommand();
            this.ShowCharacterInfoPanel.OnNext(cmd);
        }
        
        public virtual void ShowGongFaPanel_() {
            var cmd = new ShowGongFaPanelCommand();
            this.ShowGongFaPanel.OnNext(cmd);
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
            list.Add(new ViewModelCommandInfo("ShowSectPanel", ShowSectPanel) { ParameterType = typeof(ShowSectPanelCommand) });
            list.Add(new ViewModelCommandInfo("ShowAvatarBagPanel", ShowAvatarBagPanel) { ParameterType = typeof(ShowAvatarBagPanelCommand) });
            list.Add(new ViewModelCommandInfo("ExitArena", ExitArena) { ParameterType = typeof(ExitArenaCommand) });
            list.Add(new ViewModelCommandInfo("ShowRankingListPanel", ShowRankingListPanel) { ParameterType = typeof(ShowRankingListPanelCommand) });
            list.Add(new ViewModelCommandInfo("ShowCharacterInfoPanel", ShowCharacterInfoPanel) { ParameterType = typeof(ShowCharacterInfoPanelCommand) });
            list.Add(new ViewModelCommandInfo("ShowGongFaPanel", ShowGongFaPanel) { ParameterType = typeof(ShowGongFaPanelCommand) });
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
