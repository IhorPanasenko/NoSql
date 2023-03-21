using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = String.Empty;

        [BsonElement("when_was_created")]
        public DateTime WhenWasCreated { get; set; }

        [BsonElement("author")]
        public string Author { get; set; } = String.Empty;

        [BsonElement("number_of_pages")]
        public int NumberOfPages { get; set; }

    }
}
