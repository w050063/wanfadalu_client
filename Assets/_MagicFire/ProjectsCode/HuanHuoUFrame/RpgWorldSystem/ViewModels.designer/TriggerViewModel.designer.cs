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
    
    
    public partial class TriggerViewModelBase : EntityCommonViewModel {
        
        private P<Single> _triggerSizeProperty;
        
        private P<String> _triggerTypeProperty;
        
        private P<Int32> _circleTriggerProperty;
        
        private P<String> _campNameProperty;
        
        private P<Int32> _triggerIDProperty;
        
        private P<Single> _lifeSpansProperty;
        
        public TriggerViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<Single> triggerSizeProperty {
            get {
                return _triggerSizeProperty;
            }
            set {
                _triggerSizeProperty = value;
            }
        }
        
        public virtual P<String> triggerTypeProperty {
            get {
                return _triggerTypeProperty;
            }
            set {
                _triggerTypeProperty = value;
            }
        }
        
        public virtual P<Int32> circleTriggerProperty {
            get {
                return _circleTriggerProperty;
            }
            set {
                _circleTriggerProperty = value;
            }
        }
        
        public virtual P<String> campNameProperty {
            get {
                return _campNameProperty;
            }
            set {
                _campNameProperty = value;
            }
        }
        
        public virtual P<Int32> triggerIDProperty {
            get {
                return _triggerIDProperty;
            }
            set {
                _triggerIDProperty = value;
            }
        }
        
        public virtual P<Single> lifeSpansProperty {
            get {
                return _lifeSpansProperty;
            }
            set {
                _lifeSpansProperty = value;
            }
        }
        
        public virtual Single triggerSize {
            get {
                return triggerSizeProperty.Value;
            }
            set {
                triggerSizeProperty.Value = value;
            }
        }
        
        public virtual String triggerType {
            get {
                return triggerTypeProperty.Value;
            }
            set {
                triggerTypeProperty.Value = value;
            }
        }
        
        public virtual Int32 circleTrigger {
            get {
                return circleTriggerProperty.Value;
            }
            set {
                circleTriggerProperty.Value = value;
            }
        }
        
        public virtual String campName {
            get {
                return campNameProperty.Value;
            }
            set {
                campNameProperty.Value = value;
            }
        }
        
        public virtual Int32 triggerID {
            get {
                return triggerIDProperty.Value;
            }
            set {
                triggerIDProperty.Value = value;
            }
        }
        
        public virtual Single lifeSpans {
            get {
                return lifeSpansProperty.Value;
            }
            set {
                lifeSpansProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _triggerSizeProperty = new P<Single>(this, "triggerSize");
            _triggerTypeProperty = new P<String>(this, "triggerType");
            _circleTriggerProperty = new P<Int32>(this, "circleTrigger");
            _campNameProperty = new P<String>(this, "campName");
            _triggerIDProperty = new P<Int32>(this, "triggerID");
            _lifeSpansProperty = new P<Single>(this, "lifeSpans");
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.triggerSize = stream.DeserializeFloat("triggerSize");;
            this.triggerType = stream.DeserializeString("triggerType");;
            this.circleTrigger = stream.DeserializeInt("circleTrigger");;
            this.campName = stream.DeserializeString("campName");;
            this.triggerID = stream.DeserializeInt("triggerID");;
            this.lifeSpans = stream.DeserializeFloat("lifeSpans");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeFloat("triggerSize", this.triggerSize);
            stream.SerializeString("triggerType", this.triggerType);
            stream.SerializeInt("circleTrigger", this.circleTrigger);
            stream.SerializeString("campName", this.campName);
            stream.SerializeInt("triggerID", this.triggerID);
            stream.SerializeFloat("lifeSpans", this.lifeSpans);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_triggerSizeProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_triggerTypeProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_circleTriggerProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_campNameProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_triggerIDProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_lifeSpansProperty, false, false, false, false));
        }
    }
    
    public partial class TriggerViewModel {
        
        public TriggerViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
