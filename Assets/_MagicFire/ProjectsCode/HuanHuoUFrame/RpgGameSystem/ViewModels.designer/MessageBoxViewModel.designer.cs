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
    
    
    public partial class MessageBoxViewModelBase : uFrame.MVVM.ViewModels.ViewModel {
        
        private P<String> _MessageProperty;
        
        private Signal<ShowMessageCommand> _ShowMessage;
        
        private Signal<CloseMessageCommand> _CloseMessage;
        
        public MessageBoxViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<String> MessageProperty {
            get {
                return _MessageProperty;
            }
            set {
                _MessageProperty = value;
            }
        }
        
        public virtual String Message {
            get {
                return MessageProperty.Value;
            }
            set {
                MessageProperty.Value = value;
            }
        }
        
        public virtual Signal<ShowMessageCommand> ShowMessage {
            get {
                return _ShowMessage;
            }
            set {
                _ShowMessage = value;
            }
        }
        
        public virtual Signal<CloseMessageCommand> CloseMessage {
            get {
                return _CloseMessage;
            }
            set {
                _CloseMessage = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.ShowMessage = new Signal<ShowMessageCommand>(this);
            this.CloseMessage = new Signal<CloseMessageCommand>(this);
            _MessageProperty = new P<String>(this, "Message");
        }
        
        public virtual void Execute(ShowMessageCommand argument) {
            this.ShowMessage.OnNext(argument);
        }
        
        public virtual void Execute(CloseMessageCommand argument) {
            this.CloseMessage.OnNext(argument);
        }
        
        public virtual void ShowMessage_() {
            var cmd = new ShowMessageCommand();
            this.ShowMessage.OnNext(cmd);
        }
        
        public virtual void CloseMessage_() {
            var cmd = new CloseMessageCommand();
            this.CloseMessage.OnNext(cmd);
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.Message = stream.DeserializeString("Message");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeString("Message", this.Message);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("ShowMessage", ShowMessage) { ParameterType = typeof(ShowMessageCommand) });
            list.Add(new ViewModelCommandInfo("CloseMessage", CloseMessage) { ParameterType = typeof(CloseMessageCommand) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_MessageProperty, false, false, false, false));
        }
    }
    
    public partial class MessageBoxViewModel {
        
        public MessageBoxViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
