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
using NMF.Models.Meta;
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

namespace NMF.Models.Changes
{
    
    
    /// <summary>
    /// The public interface for AssociationListInsertion
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AssociationListInsertion))]
    [XmlDefaultImplementationTypeAttribute(typeof(AssociationListInsertion))]
    public interface IAssociationListInsertion : NMF.Models.IModelElement, IListInsertion
    {
        
        /// <summary>
        /// The addedElement property
        /// </summary>
        NMF.Models.IModelElement AddedElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AddedElement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddedElementChanging;
        
        /// <summary>
        /// Gets fired when the AddedElement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AddedElementChanged;
    }
}
