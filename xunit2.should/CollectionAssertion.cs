﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class CollectionAssertion
    {
        /// <summary>
        /// Should contain a given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The object expected to be in the collection.</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected)
        {
           Assert.Contains(expected, actual);
        }

        /// <summary>
        /// Should contain a given object using an equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected to be in the collection.</param>
        /// <param name="comparer">The equality comparer</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.Contains(expected, actual, comparer);
        }

        /// <summary>
        /// Should contain a given object using a filter to find that object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="filter">The filter used to find the item you're ensuring the collection contains.</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, Predicate<T> filter)
        {
            Assert.Contains(actual, filter);
        }


        /// <summary>
        /// Should contain exactly a given number of elements and elements should meet the criteria provided in the criteria parameter.
        /// </summary>
        /// <typeparam name="T">Type of object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="criteria">The criteria which inspect each element. The total number of criteria should match the number of elements in the collection.</param>
        public static void ShouldContainElementsWithCriteriaAs<T>(this IEnumerable<T> actual, params Action<T>[] criteria)
        {
            Assert.Collection(actual, criteria);
        }

        /// <summary>
        /// Should Not contain a given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected Not to be in the collection.</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected)
        {
            Assert.DoesNotContain(expected, actual);
        }

        /// <summary>
        /// Should Not contain a given object using an equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected Not to be in the collection.</param>
        /// <param name="comparer">The equality comparer</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.DoesNotContain(expected, actual, comparer);
        }


        /// <summary>
        /// Should Not contain a given object using a filter to find that object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="filter">The filter used to search for the item you're ensuring is Not in the collection.</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, Predicate<T> filter)
        {
            Assert.DoesNotContain(actual, filter);
        }

        /// <summary>
        /// Verifies that all items in the collection pass when executed against action.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="action">The action to test each item against</param>
        public static void ShouldAllPass <T>(this IEnumerable<T> actual, Action<T> action)
        {
            Assert.All(actual, action);
        }


    }
}
