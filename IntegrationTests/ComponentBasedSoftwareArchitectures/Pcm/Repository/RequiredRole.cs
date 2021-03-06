//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the RequiredRole class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RequiredRole")]
    [DebuggerDisplayAttribute("RequiredRole {Id}")]
    public abstract partial class RequiredRole : Role, IRequiredRole, IModelElement
    {
        
        private static Lazy<ITypedElement> _requiringEntity_RequiredRoleReference = new Lazy<ITypedElement>(RetrieveRequiringEntity_RequiredRoleReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The requiringEntity_RequiredRole property
        /// </summary>
        [XmlElementNameAttribute("requiringEntity_RequiredRole")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("requiredRoles_InterfaceRequiringEntity")]
        public IInterfaceRequiringEntity RequiringEntity_RequiredRole
        {
            get
            {
                return ModelHelper.CastAs<IInterfaceRequiringEntity>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RequiredRoleReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RequiredRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the RequiringEntity_RequiredRole property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> RequiringEntity_RequiredRoleChanging;
        
        /// <summary>
        /// Gets fired when the RequiringEntity_RequiredRole property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> RequiringEntity_RequiredRoleChanged;
        
        private static ITypedElement RetrieveRequiringEntity_RequiredRoleReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.RequiredRole.ClassInstance)).Resolve("requiringEntity_RequiredRole")));
        }
        
        /// <summary>
        /// Raises the RequiringEntity_RequiredRoleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRequiringEntity_RequiredRoleChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.RequiringEntity_RequiredRoleChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IInterfaceRequiringEntity oldRequiringEntity_RequiredRole = ModelHelper.CastAs<IInterfaceRequiringEntity>(oldParent);
            IInterfaceRequiringEntity newRequiringEntity_RequiredRole = ModelHelper.CastAs<IInterfaceRequiringEntity>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRequiringEntity_RequiredRole, newRequiringEntity_RequiredRole);
            this.OnRequiringEntity_RequiredRoleChanging(e);
            this.OnPropertyChanging("RequiringEntity_RequiredRole", e, _requiringEntity_RequiredRoleReference);
        }
        
        /// <summary>
        /// Raises the RequiringEntity_RequiredRoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRequiringEntity_RequiredRoleChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.RequiringEntity_RequiredRoleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IInterfaceRequiringEntity oldRequiringEntity_RequiredRole = ModelHelper.CastAs<IInterfaceRequiringEntity>(oldParent);
            IInterfaceRequiringEntity newRequiringEntity_RequiredRole = ModelHelper.CastAs<IInterfaceRequiringEntity>(newParent);
            if ((oldRequiringEntity_RequiredRole != null))
            {
                oldRequiringEntity_RequiredRole.RequiredRoles_InterfaceRequiringEntity.Remove(this);
            }
            if ((newRequiringEntity_RequiredRole != null))
            {
                newRequiringEntity_RequiredRole.RequiredRoles_InterfaceRequiringEntity.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRequiringEntity_RequiredRole, newRequiringEntity_RequiredRole);
            this.OnRequiringEntity_RequiredRoleChanged(e);
            this.OnPropertyChanged("RequiringEntity_RequiredRole", e, _requiringEntity_RequiredRoleReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REQUIRINGENTITY_REQUIREDROLE"))
            {
                this.RequiringEntity_RequiredRole = ((IInterfaceRequiringEntity)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "RequiringEntity_RequiredRole"))
            {
                return new RequiringEntity_RequiredRoleProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "RequiringEntity_RequiredRole"))
            {
                return new RequiringEntity_RequiredRoleProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/RequiredRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RequiredRole class
        /// </summary>
        public class RequiredRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RequiredRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RequiredRoleReferencedElementsCollection(RequiredRole parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.RequiringEntity_RequiredRole != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiringEntity_RequiredRoleChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiringEntity_RequiredRoleChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RequiringEntity_RequiredRole == null))
                {
                    IInterfaceRequiringEntity requiringEntity_RequiredRoleCasted = item.As<IInterfaceRequiringEntity>();
                    if ((requiringEntity_RequiredRoleCasted != null))
                    {
                        this._parent.RequiringEntity_RequiredRole = requiringEntity_RequiredRoleCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiringEntity_RequiredRole = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RequiringEntity_RequiredRole))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.RequiringEntity_RequiredRole != null))
                {
                    array[arrayIndex] = this._parent.RequiringEntity_RequiredRole;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.RequiringEntity_RequiredRole == item))
                {
                    this._parent.RequiringEntity_RequiredRole = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiringEntity_RequiredRole).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the requiringEntity_RequiredRole property
        /// </summary>
        private sealed class RequiringEntity_RequiredRoleProxy : ModelPropertyChange<IRequiredRole, IInterfaceRequiringEntity>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RequiringEntity_RequiredRoleProxy(IRequiredRole modelElement) : 
                    base(modelElement, "requiringEntity_RequiredRole")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInterfaceRequiringEntity Value
            {
                get
                {
                    return this.ModelElement.RequiringEntity_RequiredRole;
                }
                set
                {
                    this.ModelElement.RequiringEntity_RequiredRole = value;
                }
            }
        }
    }
}

