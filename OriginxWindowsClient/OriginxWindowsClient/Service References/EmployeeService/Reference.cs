﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OriginxWindowsClient.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeClass", Namespace="http://schemas.datacontract.org/2004/07/OrginxDataService")]
    [System.SerializableAttribute()]
    public partial class EmployeeClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Emp_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int User_levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public int Emp_ID {
            get {
                return this.Emp_IDField;
            }
            set {
                if ((this.Emp_IDField.Equals(value) != true)) {
                    this.Emp_IDField = value;
                    this.RaisePropertyChanged("Emp_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int User_level {
            get {
                return this.User_levelField;
            }
            set {
                if ((this.User_levelField.Equals(value) != true)) {
                    this.User_levelField = value;
                    this.RaisePropertyChanged("User_level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IOriginxDataService")]
    public interface IOriginxDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        string getMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        System.Threading.Tasks.Task<string> getMessageAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOriginxDataServiceChannel : OriginxWindowsClient.EmployeeService.IOriginxDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OriginxDataServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.EmployeeService.IOriginxDataService>, OriginxWindowsClient.EmployeeService.IOriginxDataService {
        
        public OriginxDataServiceClient() {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMessage(string name) {
            return base.Channel.getMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> getMessageAsync(string name) {
            return base.Channel.getMessageAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/addEmployee", ReplyAction="http://tempuri.org/IEmployeeService/addEmployeeResponse")]
        void addEmployee(OriginxWindowsClient.EmployeeService.EmployeeClass emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/addEmployee", ReplyAction="http://tempuri.org/IEmployeeService/addEmployeeResponse")]
        System.Threading.Tasks.Task addEmployeeAsync(OriginxWindowsClient.EmployeeService.EmployeeClass emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : OriginxWindowsClient.EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.EmployeeService.IEmployeeService>, OriginxWindowsClient.EmployeeService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addEmployee(OriginxWindowsClient.EmployeeService.EmployeeClass emp) {
            base.Channel.addEmployee(emp);
        }
        
        public System.Threading.Tasks.Task addEmployeeAsync(OriginxWindowsClient.EmployeeService.EmployeeClass emp) {
            return base.Channel.addEmployeeAsync(emp);
        }
    }
}