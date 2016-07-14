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
    /// The public interface for Class
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Class))]
    [XmlDefaultImplementationTypeAttribute(typeof(Class))]
    public interface IClass : IModelElement, IReferenceType
    {
        
        /// <summary>
        /// The IsAbstract property
        /// </summary>
        bool IsAbstract
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies whether the identifier is valid only in the scope of its container or on a global scope.
        /// </summary>
        /// <remarks>This attribute is ignored when this class is not identified.</remarks>
        IdentifierScope IdentifierScope
        {
            get;
            set;
        }
        
        /// <summary>
        /// The BaseTypes property
        /// </summary>
        ICollectionExpression<IClass> BaseTypes
        {
            get;
        }
        
        /// <summary>
        /// The InstanceOf property
        /// </summary>
        IClass InstanceOf
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the attribute that will identify instances of this class
        /// </summary>
        IAttribute Identifier
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AttributeConstraints property
        /// </summary>
        ICollectionExpression<IAttributeConstraint> AttributeConstraints
        {
            get;
        }
        
        /// <summary>
        /// The ReferenceConstraints property
        /// </summary>
        ICollectionExpression<IReferenceConstraint> ReferenceConstraints
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the IsAbstract property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> IsAbstractChanged;
        
        /// <summary>
        /// Gets fired when the IdentifierScope property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> IdentifierScopeChanged;
        
        /// <summary>
        /// Gets fired when the InstanceOf property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InstanceOfChanged;
        
        /// <summary>
        /// Gets fired when the Identifier property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> IdentifierChanged;
    }
}

