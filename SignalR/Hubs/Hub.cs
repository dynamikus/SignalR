﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    /// <summary>
    /// Provides methods that communicate with SignalR connections that connected to a <see cref="Hub"/>.
    /// </summary>
    public abstract class Hub : IHub, IConnected, IDisconnect
    {
        /// <summary>
        /// A dynamic object that represents all clients connected to this hub (not hub instance).
        /// </summary>
        public dynamic Clients { get; set; }

        /// <summary>
        /// A dynamic object that represents the calling client.
        /// </summary>
        public dynamic Caller { get; set; }

        /// <summary>
        /// Provides information about the calling client.
        /// </summary>
        public HubCallerContext Context { get; set; }

        /// <summary>
        /// The group manager for this hub instance.
        /// </summary>
        public IGroupManager Groups { get; set; }

        /// <summary>
        /// Disconnect handler for this hub instance.
        /// </summary>
        /// <returns>A <see cref="Task"/></returns>
        public virtual Task Disconnect()
        {
            return TaskAsyncHelper.Empty;
        }

        /// <summary>
        /// Connection handler for this hub instance.
        /// </summary>
        /// <returns>A <see cref="Task"/></returns>
        public virtual Task Connect()
        {
            return TaskAsyncHelper.Empty;
        }

        /// <summary>
        /// Reconnect handler for this hub instance.
        /// </summary>
        /// <param name="groups">The groups that the client was subscribed to</param>
        /// <returns>A <see cref="Task"/></returns>
        public virtual Task Reconnect(IEnumerable<string> groups)
        {
            return TaskAsyncHelper.Empty;
        }
    }
}