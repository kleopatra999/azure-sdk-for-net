// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for TagsOperations.
    /// </summary>
    public static partial class TagsOperationsExtensions
    {
            /// <summary>
            /// Deletes a tag value.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to delete.
            /// </param>
            public static void DeleteValue(this ITagsOperations operations, string tagName, string tagValue)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).DeleteValueAsync(tagName, tagValue), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a tag value.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteValueAsync(this ITagsOperations operations, string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates a tag value. The name of the tag must already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to create.
            /// </param>
            public static TagValue CreateOrUpdateValue(this ITagsOperations operations, string tagName, string tagValue)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).CreateOrUpdateValueAsync(tagName, tagValue), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a tag value. The name of the tag must already exist.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='tagValue'>
            /// The value of the tag to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TagValue> CreateOrUpdateValueAsync(this ITagsOperations operations, string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a tag in the subscription.
            /// </summary>
            /// <remarks>
            /// The tag name can have a maximum of 512 characters and is case insensitive.
            /// Tag names created by Azure have prefixes of microsoft, azure, or windows.
            /// You cannot create tags with one of these prefixes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag to create.
            /// </param>
            public static TagDetails CreateOrUpdate(this ITagsOperations operations, string tagName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).CreateOrUpdateAsync(tagName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a tag in the subscription.
            /// </summary>
            /// <remarks>
            /// The tag name can have a maximum of 512 characters and is case insensitive.
            /// Tag names created by Azure have prefixes of microsoft, azure, or windows.
            /// You cannot create tags with one of these prefixes.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TagDetails> CreateOrUpdateAsync(this ITagsOperations operations, string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a tag from the subscription.
            /// </summary>
            /// <remarks>
            /// You must remove all values from a resource tag before you can delete it.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            public static void Delete(this ITagsOperations operations, string tagName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).DeleteAsync(tagName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a tag from the subscription.
            /// </summary>
            /// <remarks>
            /// You must remove all values from a resource tag before you can delete it.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tagName'>
            /// The name of the tag.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ITagsOperations operations, string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the names and values of all resource tags that are defined in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<TagDetails> List(this ITagsOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the names and values of all resource tags that are defined in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<TagDetails>> ListAsync(this ITagsOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the names and values of all resource tags that are defined in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<TagDetails> ListNext(this ITagsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITagsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the names and values of all resource tags that are defined in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<TagDetails>> ListNextAsync(this ITagsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
