using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace PetitionLog
{
    internal class SortableBindingList<T> : BindingList<T>
    {
        private bool isSorted;
        private ListSortDirection sortDirection;
        private PropertyDescriptor sortProperty;

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => isSorted;
        protected override ListSortDirection SortDirectionCore => sortDirection;
        protected override PropertyDescriptor SortPropertyCore => sortProperty;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var itemsList = (List<T>)Items;

            itemsList.Sort((x, y) =>
            {
                object a = prop.GetValue(x);
                object b = prop.GetValue(y);
                return direction == ListSortDirection.Ascending
                    ? Comparer<object>.Default.Compare(a, b)
                    : Comparer<object>.Default.Compare(b, a);
            });

            sortDirection = direction;
            sortProperty = prop;
            isSorted = true;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            isSorted = false;
        }
    }
}
