//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The public interface for Type
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Type))]
    [XmlDefaultImplementationTypeAttribute(typeof(Type))]
    public interface IType : IModelElement, IMetaElement
    {
        
        /// <summary>
        /// The Namespace property
        /// </summary>
        INamespace Namespace
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Namespace property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> NamespaceChanged;
    }
}

