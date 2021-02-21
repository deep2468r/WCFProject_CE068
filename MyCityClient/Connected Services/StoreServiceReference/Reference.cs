﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCityClient.StoreServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Store", Namespace="http://schemas.datacontract.org/2004/07/MyCityLibrary")]
    [System.SerializableAttribute()]
    public partial class Store : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StoreIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((object.ReferenceEquals(this.RatingField, value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StoreID {
            get {
                return this.StoreIDField;
            }
            set {
                if ((this.StoreIDField.Equals(value) != true)) {
                    this.StoreIDField = value;
                    this.RaisePropertyChanged("StoreID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoreServiceReference.IStoreService")]
    public interface IStoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStores", ReplyAction="http://tempuri.org/IStoreService/GetStoresResponse")]
        System.Data.DataSet GetStores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStores", ReplyAction="http://tempuri.org/IStoreService/GetStoresResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreByID", ReplyAction="http://tempuri.org/IStoreService/GetStoreByIDResponse")]
        MyCityClient.StoreServiceReference.Store GetStoreByID(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoreByID", ReplyAction="http://tempuri.org/IStoreService/GetStoreByIDResponse")]
        System.Threading.Tasks.Task<MyCityClient.StoreServiceReference.Store> GetStoreByIDAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoresByName", ReplyAction="http://tempuri.org/IStoreService/GetStoresByNameResponse")]
        System.Data.DataSet GetStoresByName(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoresByName", ReplyAction="http://tempuri.org/IStoreService/GetStoresByNameResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStoresByNameAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoresByCategory", ReplyAction="http://tempuri.org/IStoreService/GetStoresByCategoryResponse")]
        System.Data.DataSet GetStoresByCategory(string Category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetStoresByCategory", ReplyAction="http://tempuri.org/IStoreService/GetStoresByCategoryResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStoresByCategoryAsync(string Category);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStoreServiceChannel : MyCityClient.StoreServiceReference.IStoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StoreServiceClient : System.ServiceModel.ClientBase<MyCityClient.StoreServiceReference.IStoreService>, MyCityClient.StoreServiceReference.IStoreService {
        
        public StoreServiceClient() {
        }
        
        public StoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetStores() {
            return base.Channel.GetStores();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStoresAsync() {
            return base.Channel.GetStoresAsync();
        }
        
        public MyCityClient.StoreServiceReference.Store GetStoreByID(string ID) {
            return base.Channel.GetStoreByID(ID);
        }
        
        public System.Threading.Tasks.Task<MyCityClient.StoreServiceReference.Store> GetStoreByIDAsync(string ID) {
            return base.Channel.GetStoreByIDAsync(ID);
        }
        
        public System.Data.DataSet GetStoresByName(string Name) {
            return base.Channel.GetStoresByName(Name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStoresByNameAsync(string Name) {
            return base.Channel.GetStoresByNameAsync(Name);
        }
        
        public System.Data.DataSet GetStoresByCategory(string Category) {
            return base.Channel.GetStoresByCategory(Category);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStoresByCategoryAsync(string Category) {
            return base.Channel.GetStoresByCategoryAsync(Category);
        }
    }
}