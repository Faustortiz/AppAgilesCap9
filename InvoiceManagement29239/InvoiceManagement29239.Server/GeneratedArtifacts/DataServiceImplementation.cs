﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Invoice))
            {
                return new global::LightSwitchApplication.Implementation.Invoice();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.OrderDetail))
            {
                return new global::LightSwitchApplication.Implementation.OrderDetail();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.OrderHeader))
            {
                return new global::LightSwitchApplication.Implementation.OrderHeader();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Product))
            {
                return new global::LightSwitchApplication.Implementation.Product();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Invoice))
            {
                return new global::LightSwitchApplication.Implementation.Invoice();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.OrderDetail))
            {
                return new global::LightSwitchApplication.Implementation.OrderDetail();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.OrderHeader))
            {
                return new global::LightSwitchApplication.Implementation.OrderHeader();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Product))
            {
                return new global::LightSwitchApplication.Implementation.Product();
            }
            return null;
        }
    
    #endregion
    
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NorthwindDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.NorthwindData>
    {
    
        public NorthwindDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).NorthwindData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NorthwindDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.NorthwindData>
    {
        public NorthwindDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.CategoriesItem))
            {
                return new global::LightSwitchApplication.Implementation.CategoriesItem();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Product_Sales_for_1997Item))
            {
                return new global::LightSwitchApplication.Implementation.Product_Sales_for_1997Item();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.ProductsItem))
            {
                return new global::LightSwitchApplication.Implementation.ProductsItem();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.NorthwindData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.NorthwindData(this.GetEntityConnectionString(
                "NorthwindData",
                "res://" + assemblyName + "/NorthwindData.csdl|res://" + assemblyName + "/NorthwindData.ssdl|res://" + assemblyName + "/NorthwindData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.CategoriesItem))
            {
                return new global::LightSwitchApplication.Implementation.CategoriesItem();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Product_Sales_for_1997Item))
            {
                return new global::LightSwitchApplication.Implementation.Product_Sales_for_1997Item();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.ProductsItem))
            {
                return new global::LightSwitchApplication.Implementation.ProductsItem();
            }
            return null;
        }
    
    #endregion
    
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NorthwindData1DataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.NorthwindData1>
    {
    
        public NorthwindData1DataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).NorthwindData1;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class NorthwindData1ServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.NorthwindData1>
    {
        public NorthwindData1ServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.EmployeesItem))
            {
                return new global::LightSwitchApplication.Implementation.EmployeesItem();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.NorthwindData1 CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.NorthwindData1(this.GetEntityConnectionString(
                "NorthwindData1",
                "res://" + assemblyName + "/NorthwindData1.csdl|res://" + assemblyName + "/NorthwindData1.ssdl|res://" + assemblyName + "/NorthwindData1.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.EmployeesItem))
            {
                return new global::LightSwitchApplication.Implementation.EmployeesItem();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.NorthwindDataService))
            {
                return new global::LightSwitchApplication.NorthwindDataService();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.NorthwindData1Service))
            {
                return new global::LightSwitchApplication.NorthwindData1Service();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.NorthwindDataService))
            {
                return new global::LightSwitchApplication.Implementation.NorthwindDataServiceImplementation(dataService);
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.NorthwindData1Service))
            {
                return new global::LightSwitchApplication.Implementation.NorthwindData1ServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Customer) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Customer);
            }
            if (typeof(global::LightSwitchApplication.Invoice) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Invoice);
            }
            if (typeof(global::LightSwitchApplication.OrderDetail) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.OrderDetail);
            }
            if (typeof(global::LightSwitchApplication.OrderHeader) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.OrderHeader);
            }
            if (typeof(global::LightSwitchApplication.Product) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Product);
            }
            if (typeof(global::LightSwitchApplication.CategoriesItem) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.CategoriesItem);
            }
            if (typeof(global::LightSwitchApplication.Product_Sales_for_1997Item) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Product_Sales_for_1997Item);
            }
            if (typeof(global::LightSwitchApplication.ProductsItem) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.ProductsItem);
            }
            if (typeof(global::LightSwitchApplication.EmployeesItem) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.EmployeesItem);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Customer :
        global::LightSwitchApplication.Customer.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.OrderHeaderCollection
        {
            get
            {
                return this.OrderHeaderCollection;
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.InvoiceCollection
        {
            get
            {
                return this.InvoiceCollection;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Invoice :
        global::LightSwitchApplication.Invoice.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Invoice.DetailsClass.IImplementation.OrderHeader
        {
            get
            {
                return this.OrderHeader;
            }
            set
            {
                this.OrderHeader = (global::LightSwitchApplication.Implementation.OrderHeader)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrderHeader");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Invoice.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::LightSwitchApplication.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Customer");
                }
            }
        }
        
        partial void OnIdChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrderHeader");
            }
        }
        
        partial void OnCustomer_InvoiceChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Customer");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrderDetail :
        global::LightSwitchApplication.OrderDetail.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderDetail.DetailsClass.IImplementation.OrderHeader
        {
            get
            {
                return this.OrderHeader;
            }
            set
            {
                this.OrderHeader = (global::LightSwitchApplication.Implementation.OrderHeader)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrderHeader");
                }
            }
        }
        
        partial void OnOrderHeader_OrderDetailChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrderHeader");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrderHeader :
        global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::LightSwitchApplication.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Customer");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation.OrderDetailCollection
        {
            get
            {
                return this.OrderDetailCollection;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation.Invoice
        {
            get
            {
                return this.Invoice;
            }
            set
            {
                this.Invoice = (global::LightSwitchApplication.Implementation.Invoice)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Invoice");
                }
            }
        }
        
        partial void OnOrderHeader_CustomerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Customer");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product :
        global::LightSwitchApplication.Product.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class CategoriesItem :
        global::LightSwitchApplication.CategoriesItem.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.CategoriesItem.DetailsClass.IImplementation.Products
        {
            get
            {
                return this.Products;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product_Sales_for_1997Item :
        global::LightSwitchApplication.Product_Sales_for_1997Item.DetailsClass.IImplementation
    {
    
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ProductsItem :
        global::LightSwitchApplication.ProductsItem.DetailsClass.IImplementation
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.ProductsItem.DetailsClass.IImplementation.CategoriesItem
        {
            get
            {
                return this.CategoriesItem;
            }
            set
            {
                this.CategoriesItem = (global::LightSwitchApplication.Implementation.CategoriesItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("CategoriesItem");
                }
            }
        }
        
        partial void OnCategoryIDChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("CategoriesItem");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class EmployeesItem :
        global::LightSwitchApplication.EmployeesItem.DetailsClass.IImplementation
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.EmployeesItem.DetailsClass.IImplementation.Employees
        {
            get
            {
                return this.Employees;
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.EmployeesItem.DetailsClass.IImplementation.Manager
        {
            get
            {
                return this.Manager;
            }
            set
            {
                this.Manager = (global::LightSwitchApplication.Implementation.EmployeesItem)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Manager");
                }
            }
        }
        
        partial void OnReportsToChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Manager");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
