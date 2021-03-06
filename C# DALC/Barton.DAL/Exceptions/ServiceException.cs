/*
*  Copyright (c) 2017, TopCoder, Inc. All rights reserved.
*/

using System;
using System.Runtime.Serialization;

namespace Barton.DAL.Exceptions
{
    /// <summary>
    /// <para>
    /// This is the base exception for all exceptions in this module.
    /// </para>
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// This exception extends ApplicationException.
    /// </para>
    /// </remarks>
    ///
    /// <threadsafety>
    /// This class isn't thread safe, because the base class is not thread safe.
    /// </threadsafety>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2017, TopCoder, Inc. All rights reserved.</copyright>
    [Serializable]
    public class ServiceException : ApplicationException
    {
        /// <summary>
        /// <para>
        /// Initializes a new instance of the <see cref="ServiceException"/> class.
        /// </para>
        /// </summary>
        public ServiceException()
        {
        }

        /// <summary>
        /// <para>
        /// Initializes a new instance of the <see cref="ServiceException"/> class
        /// with a specified error message.
        /// </para>
        /// </summary>
        ///
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public ServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// <para>
        /// Initializes a new instance of the <see cref="ServiceException"/> class
        /// with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </para>
        /// </summary>
        ///
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference if no inner exception is
        /// specified.
        /// </param>
        public ServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// <para>
        /// Initializes a new instance of the <see cref="ServiceException"/> class
        /// with serialized data.
        /// </para>
        /// </summary>
        ///
        /// <param name="info">
        /// The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.
        /// </param>
        /// <param name="context">
        /// The <see cref="StreamingContext"/> that contains contextual information about the source or destination.
        /// </param>
        protected ServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}