﻿namespace CacheManager.Core.Configuration
{
    /// <summary>
    /// Defines the contract for the cache manager configuration.
    /// </summary>
    public interface ICacheManagerConfiguration
    {
        /// <summary>
        /// Gets the cache update mode.
        /// </summary>
        /// <value>The cache update mode.</value>
        /// <see cref="CacheUpdateMode"/>
        CacheUpdateMode CacheUpdateMode { get; }

        /// <summary>
        /// Gets or sets the limit of the number of retry operations per action. Default is <see cref="int.MaxValue"/>.
        /// </summary>
        /// <value>The maximum retries.</value>
        int MaxRetries { get; set; }

        /// <summary>
        /// Gets the name the cache will be using.
        /// <para>The name might be used by several components as an identifier or display name.</para>
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Gets or sets the number of milliseconds the cache should wait before it will retry an action.
        /// </summary>
        /// <value>The retry timeout.</value>
        int RetryTimeout { get; set; }
    }
}