﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace SilverlightLoginSQL.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="zhuce", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class zhuce : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string passwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ServiceReference1.Service")]
    public interface Service {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Service/GetData", ReplyAction="urn:Service/GetDataResponse")]
        System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Service/CheckName", ReplyAction="urn:Service/CheckNameResponse")]
        System.IAsyncResult BeginCheckName(string nm, System.AsyncCallback callback, object asyncState);
        
        string EndCheckName(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Service/Tianjia", ReplyAction="urn:Service/TianjiaResponse")]
        System.IAsyncResult BeginTianjia(string nms, string pass, System.AsyncCallback callback, object asyncState);
        
        string EndTianjia(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Service/CheckPassword", ReplyAction="urn:Service/CheckPasswordResponse")]
        System.IAsyncResult BeginCheckPassword(string pw, System.AsyncCallback callback, object asyncState);
        
        string EndCheckPassword(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceChannel : SilverlightLoginSQL.ServiceReference1.Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CheckNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TianjiaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TianjiaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CheckPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SilverlightLoginSQL.ServiceReference1.Service>, SilverlightLoginSQL.ServiceReference1.Service {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginCheckNameDelegate;
        
        private EndOperationDelegate onEndCheckNameDelegate;
        
        private System.Threading.SendOrPostCallback onCheckNameCompletedDelegate;
        
        private BeginOperationDelegate onBeginTianjiaDelegate;
        
        private EndOperationDelegate onEndTianjiaDelegate;
        
        private System.Threading.SendOrPostCallback onTianjiaCompletedDelegate;
        
        private BeginOperationDelegate onBeginCheckPasswordDelegate;
        
        private EndOperationDelegate onEndCheckPasswordDelegate;
        
        private System.Threading.SendOrPostCallback onCheckPasswordCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("无法设置 CookieContainer。请确保绑定包含 HttpCookieContainerBindingElement。");
                }
            }
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<CheckNameCompletedEventArgs> CheckNameCompleted;
        
        public event System.EventHandler<TianjiaCompletedEventArgs> TianjiaCompleted;
        
        public event System.EventHandler<CheckPasswordCompletedEventArgs> CheckPasswordCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightLoginSQL.ServiceReference1.Service.BeginGetData(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> SilverlightLoginSQL.ServiceReference1.Service.EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SilverlightLoginSQL.ServiceReference1.Service)(this)).BeginGetData(callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> retVal = ((SilverlightLoginSQL.ServiceReference1.Service)(this)).EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync() {
            this.GetDataAsync(null);
        }
        
        public void GetDataAsync(object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, null, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightLoginSQL.ServiceReference1.Service.BeginCheckName(string nm, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCheckName(nm, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SilverlightLoginSQL.ServiceReference1.Service.EndCheckName(System.IAsyncResult result) {
            return base.Channel.EndCheckName(result);
        }
        
        private System.IAsyncResult OnBeginCheckName(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nm = ((string)(inValues[0]));
            return ((SilverlightLoginSQL.ServiceReference1.Service)(this)).BeginCheckName(nm, callback, asyncState);
        }
        
        private object[] OnEndCheckName(System.IAsyncResult result) {
            string retVal = ((SilverlightLoginSQL.ServiceReference1.Service)(this)).EndCheckName(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCheckNameCompleted(object state) {
            if ((this.CheckNameCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CheckNameCompleted(this, new CheckNameCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CheckNameAsync(string nm) {
            this.CheckNameAsync(nm, null);
        }
        
        public void CheckNameAsync(string nm, object userState) {
            if ((this.onBeginCheckNameDelegate == null)) {
                this.onBeginCheckNameDelegate = new BeginOperationDelegate(this.OnBeginCheckName);
            }
            if ((this.onEndCheckNameDelegate == null)) {
                this.onEndCheckNameDelegate = new EndOperationDelegate(this.OnEndCheckName);
            }
            if ((this.onCheckNameCompletedDelegate == null)) {
                this.onCheckNameCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCheckNameCompleted);
            }
            base.InvokeAsync(this.onBeginCheckNameDelegate, new object[] {
                        nm}, this.onEndCheckNameDelegate, this.onCheckNameCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightLoginSQL.ServiceReference1.Service.BeginTianjia(string nms, string pass, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTianjia(nms, pass, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SilverlightLoginSQL.ServiceReference1.Service.EndTianjia(System.IAsyncResult result) {
            return base.Channel.EndTianjia(result);
        }
        
        private System.IAsyncResult OnBeginTianjia(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nms = ((string)(inValues[0]));
            string pass = ((string)(inValues[1]));
            return ((SilverlightLoginSQL.ServiceReference1.Service)(this)).BeginTianjia(nms, pass, callback, asyncState);
        }
        
        private object[] OnEndTianjia(System.IAsyncResult result) {
            string retVal = ((SilverlightLoginSQL.ServiceReference1.Service)(this)).EndTianjia(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTianjiaCompleted(object state) {
            if ((this.TianjiaCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TianjiaCompleted(this, new TianjiaCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TianjiaAsync(string nms, string pass) {
            this.TianjiaAsync(nms, pass, null);
        }
        
        public void TianjiaAsync(string nms, string pass, object userState) {
            if ((this.onBeginTianjiaDelegate == null)) {
                this.onBeginTianjiaDelegate = new BeginOperationDelegate(this.OnBeginTianjia);
            }
            if ((this.onEndTianjiaDelegate == null)) {
                this.onEndTianjiaDelegate = new EndOperationDelegate(this.OnEndTianjia);
            }
            if ((this.onTianjiaCompletedDelegate == null)) {
                this.onTianjiaCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTianjiaCompleted);
            }
            base.InvokeAsync(this.onBeginTianjiaDelegate, new object[] {
                        nms,
                        pass}, this.onEndTianjiaDelegate, this.onTianjiaCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightLoginSQL.ServiceReference1.Service.BeginCheckPassword(string pw, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCheckPassword(pw, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string SilverlightLoginSQL.ServiceReference1.Service.EndCheckPassword(System.IAsyncResult result) {
            return base.Channel.EndCheckPassword(result);
        }
        
        private System.IAsyncResult OnBeginCheckPassword(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string pw = ((string)(inValues[0]));
            return ((SilverlightLoginSQL.ServiceReference1.Service)(this)).BeginCheckPassword(pw, callback, asyncState);
        }
        
        private object[] OnEndCheckPassword(System.IAsyncResult result) {
            string retVal = ((SilverlightLoginSQL.ServiceReference1.Service)(this)).EndCheckPassword(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCheckPasswordCompleted(object state) {
            if ((this.CheckPasswordCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CheckPasswordCompleted(this, new CheckPasswordCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CheckPasswordAsync(string pw) {
            this.CheckPasswordAsync(pw, null);
        }
        
        public void CheckPasswordAsync(string pw, object userState) {
            if ((this.onBeginCheckPasswordDelegate == null)) {
                this.onBeginCheckPasswordDelegate = new BeginOperationDelegate(this.OnBeginCheckPassword);
            }
            if ((this.onEndCheckPasswordDelegate == null)) {
                this.onEndCheckPasswordDelegate = new EndOperationDelegate(this.OnEndCheckPassword);
            }
            if ((this.onCheckPasswordCompletedDelegate == null)) {
                this.onCheckPasswordCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCheckPasswordCompleted);
            }
            base.InvokeAsync(this.onBeginCheckPasswordDelegate, new object[] {
                        pw}, this.onEndCheckPasswordDelegate, this.onCheckPasswordCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightLoginSQL.ServiceReference1.Service CreateChannel() {
            return new ServiceClientChannel(this);
        }
        
        private class ServiceClientChannel : ChannelBase<SilverlightLoginSQL.ServiceReference1.Service>, SilverlightLoginSQL.ServiceReference1.Service {
            
            public ServiceClientChannel(System.ServiceModel.ClientBase<SilverlightLoginSQL.ServiceReference1.Service> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetData", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> EndGetData(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce> _result = ((System.Collections.ObjectModel.ObservableCollection<SilverlightLoginSQL.ServiceReference1.zhuce>)(base.EndInvoke("GetData", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCheckName(string nm, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = nm;
                System.IAsyncResult _result = base.BeginInvoke("CheckName", _args, callback, asyncState);
                return _result;
            }
            
            public string EndCheckName(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("CheckName", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginTianjia(string nms, string pass, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = nms;
                _args[1] = pass;
                System.IAsyncResult _result = base.BeginInvoke("Tianjia", _args, callback, asyncState);
                return _result;
            }
            
            public string EndTianjia(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Tianjia", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCheckPassword(string pw, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = pw;
                System.IAsyncResult _result = base.BeginInvoke("CheckPassword", _args, callback, asyncState);
                return _result;
            }
            
            public string EndCheckPassword(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("CheckPassword", _args, result)));
                return _result;
            }
        }
    }
}
