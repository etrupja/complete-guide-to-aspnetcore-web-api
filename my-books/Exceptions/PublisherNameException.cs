using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Exceptions
{
    [Serializable]
    public class PublisherNameException:Exception
    {
        public string PublisherName { get; set; }

        public PublisherNameException()
        {

        }

        public PublisherNameException(string message) : base(message)
        {

        }

        public PublisherNameException(string message, Exception inner): base(message, inner)
        {

        }

        public PublisherNameException(string message, string publisherName): this(message)
        {
            PublisherName = publisherName;
        }
    }
}
