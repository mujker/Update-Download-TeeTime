﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.17929 版自动生成。
// 
#pragma warning disable 1591

namespace MiniApp.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceClientSoap", Namespace="http://192.168.0.247/")]
    public partial class ServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UpdateTeetimeMethodOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAppointmentMethodOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiceClient() {
            this.Url = global::MiniApp.Properties.Settings.Default.MiniApp_localhost_ServiceClient;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event UpdateTeetimeMethodCompletedEventHandler UpdateTeetimeMethodCompleted;
        
        /// <remarks/>
        public event GetAppointmentMethodCompletedEventHandler GetAppointmentMethodCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.0.247/UpdateTeetimeMethod", RequestNamespace="http://192.168.0.247/", ResponseNamespace="http://192.168.0.247/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateTeetimeMethod(System.Data.DataSet teetimeDataSet) {
            this.Invoke("UpdateTeetimeMethod", new object[] {
                        teetimeDataSet});
        }
        
        /// <remarks/>
        public void UpdateTeetimeMethodAsync(System.Data.DataSet teetimeDataSet) {
            this.UpdateTeetimeMethodAsync(teetimeDataSet, null);
        }
        
        /// <remarks/>
        public void UpdateTeetimeMethodAsync(System.Data.DataSet teetimeDataSet, object userState) {
            if ((this.UpdateTeetimeMethodOperationCompleted == null)) {
                this.UpdateTeetimeMethodOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTeetimeMethodOperationCompleted);
            }
            this.InvokeAsync("UpdateTeetimeMethod", new object[] {
                        teetimeDataSet}, this.UpdateTeetimeMethodOperationCompleted, userState);
        }
        
        private void OnUpdateTeetimeMethodOperationCompleted(object arg) {
            if ((this.UpdateTeetimeMethodCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTeetimeMethodCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://192.168.0.247/GetAppointmentMethod", RequestNamespace="http://192.168.0.247/", ResponseNamespace="http://192.168.0.247/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAppointmentMethod() {
            object[] results = this.Invoke("GetAppointmentMethod", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAppointmentMethodAsync() {
            this.GetAppointmentMethodAsync(null);
        }
        
        /// <remarks/>
        public void GetAppointmentMethodAsync(object userState) {
            if ((this.GetAppointmentMethodOperationCompleted == null)) {
                this.GetAppointmentMethodOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAppointmentMethodOperationCompleted);
            }
            this.InvokeAsync("GetAppointmentMethod", new object[0], this.GetAppointmentMethodOperationCompleted, userState);
        }
        
        private void OnGetAppointmentMethodOperationCompleted(object arg) {
            if ((this.GetAppointmentMethodCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAppointmentMethodCompleted(this, new GetAppointmentMethodCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void UpdateTeetimeMethodCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAppointmentMethodCompletedEventHandler(object sender, GetAppointmentMethodCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAppointmentMethodCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAppointmentMethodCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591