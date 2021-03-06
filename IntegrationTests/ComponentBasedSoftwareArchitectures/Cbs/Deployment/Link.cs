//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.Assembly;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.Deployment
{
    
    
    /// <summary>
    /// The default implementation of the Link class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/Deployment/")]
    [XmlNamespacePrefixAttribute("deploy")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Deployment/Link")]
    [DebuggerDisplayAttribute("Link {Name}")]
    public partial class Link : NamedElement, ILink, IModelElement
    {
        
        private static Lazy<ITypedElement> _connectedContainersReference = new Lazy<ITypedElement>(RetrieveConnectedContainersReference);
        
        /// <summary>
        /// The backing field for the ConnectedContainers property
        /// </summary>
        private LinkConnectedContainersCollection _connectedContainers;
        
        private static IClass _classInstance;
        
        public Link()
        {
            this._connectedContainers = new LinkConnectedContainersCollection(this);
            this._connectedContainers.CollectionChanging += this.ConnectedContainersCollectionChanging;
            this._connectedContainers.CollectionChanged += this.ConnectedContainersCollectionChanged;
        }
        
        /// <summary>
        /// The ConnectedContainers property
        /// </summary>
        [LowerBoundAttribute(2)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Links")]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IContainer_MM06> ConnectedContainers
        {
            get
            {
                return this._connectedContainers;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new LinkReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Deployment/Link")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveConnectedContainersReference()
        {
            return ((ITypedElement)(((ModelElement)(Link.ClassInstance)).Resolve("ConnectedContainers")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ConnectedContainers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectedContainersCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ConnectedContainers", e, _connectedContainersReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ConnectedContainers property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectedContainersCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConnectedContainers", e, _connectedContainersReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CONNECTEDCONTAINERS"))
            {
                return this._connectedContainers;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//Deployment/Link")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Link class
        /// </summary>
        public class LinkReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Link _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LinkReferencedElementsCollection(Link parent)
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
                    count = (count + this._parent.ConnectedContainers.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConnectedContainers.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConnectedContainers.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IContainer_MM06 connectedContainersCasted = item.As<IContainer_MM06>();
                if ((connectedContainersCasted != null))
                {
                    this._parent.ConnectedContainers.Add(connectedContainersCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConnectedContainers.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ConnectedContainers.Contains(item))
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
                IEnumerator<IModelElement> connectedContainersEnumerator = this._parent.ConnectedContainers.GetEnumerator();
                try
                {
                    for (
                    ; connectedContainersEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = connectedContainersEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    connectedContainersEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IContainer_MM06 container_MM06Item = item.As<IContainer_MM06>();
                if (((container_MM06Item != null) 
                            && this._parent.ConnectedContainers.Remove(container_MM06Item)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConnectedContainers).GetEnumerator();
            }
        }
    }
}

